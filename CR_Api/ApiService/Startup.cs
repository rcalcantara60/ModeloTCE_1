using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using IoC;
using SimpleInjector;
using SimpleInjector.Integration.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using SimpleInjector.Lifestyles;
using System.Globalization;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using TCE.Web.Api.Extensions;
using Microsoft.AspNetCore.Http;
using Application.Mappings;
using System.Collections.Generic;
//using Utils;
using System.Reflection;


namespace ApiService
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private Container _container { get; set; }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            _container = InjectorContainer.GetContainer();            
            _container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
            services.AddSingleton<IControllerActivator>(new SimpleInjectorControllerActivator(_container));
            services.AddSingleton<IViewComponentActivator>(new SimpleInjectorViewComponentActivator(_container));

            var connDict = new Dictionary<string, string>
            {
                { "ConnectionString",  Configuration["Data:ConnectionString:ConnectionString"]}
            };

            //services.AddSingleton(connDict);            

            var connectionString = Configuration["Data:Context:ConnectionString"];

            InjectorContainer.RegistrarServicos(_container, new AsyncScopedLifestyle(), connDict["ConnectionString"], connDict);

            AutoMapperConfiguration.Configure();

            services.AddCors();

            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowAllMethods",
            //        builder =>
            //        {
            //            //builder.WithOrigins("https://bronze.tce.mg.gov.br:8443").AllowAnyMethod().AllowAnyHeader();
            //            builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            //            //builder.AllowCredentials();
            //            //builder.AllowAnyHeader();
            //            //builder.AllowAnyMethod();
            //            //builder.AllowAnyOrigin();
            //        });
            //});

            var cultureInfo = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

            //Avoid CamelCase.
            services.AddMvc()
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver());
            services.AddMvc()
                .AddJsonOptions(options => options.SerializerSettings.DateFormatString = "dd/MM/yyyy");


            // Register the Swagger generator, defining one or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Title = "MODELO HR.",
                    Version = "v1"
                });
            });            


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();                
            }

            //app.UseCors("AllowAllMethods");

            //app.UseCors(builder => builder
            //            .WithOrigins("http://dotnet.tce.mg.gov.br")
            //            .AllowAnyMethod()
            //            .AllowAnyHeader());

            
            
            app.UseSimpleInjectorAspNetRequestScoping(_container);

            _container.RegisterMvcControllers(app);
            _container.RegisterMvcViewComponents(app);
            _container.Verify();
            //app.UseMiddleware<AuthenticationMiddleware>();

            app.UseExceptionHandler(
              builder =>
              {
                  builder.Run(
                    async context =>
                    {
                        var error = context.Features.Get<IExceptionHandlerFeature>();
                        if (error != null)
                        {
                            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                            context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                            context.Response.AddApplicationError(MontaErroAplicacao(error));
                            await context.Response.WriteAsync(MontaErroAplicacao(error)).ConfigureAwait(false);
                        }
                    });
              });

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS etc.), specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "My API V1");
                c.IndexStream = () => GetType().GetTypeInfo().Assembly.GetManifestResourceStream("ApiService.index.html");

            });

            app.UseMvc();
        }

        private string MontaErroAplicacao(IExceptionHandlerFeature error)
        {
            return $"Error: {error.Error.Message} | Inner Error: {error.Error.InnerException?.Message}";
        }
    }
}
