using Domain.Entities;
using Domain.Interfaces.Services;
using Domain.Services;
using FluentValidation;
using NUnit.Framework;
using SimpleInjector;
using SpecFlow.SimpleInjector;
using System;
using TechTalk.SpecFlow;
using TestProject.Contexts;
using TestProject.Support;

namespace TestProject.Steps
{
    [Binding]
    public class GerenciamentoDosPaisesSteps
    {
        private readonly ContainerContext _containerContext;
        COUNTRy country = new COUNTRy();

        public GerenciamentoDosPaisesSteps(ContainerContext containerContext)
        {
            _containerContext = containerContext;
        }

        [Given(@"que o nome do pais seja '(.*)'")]
        public void DadoQueONomeDoPaisSeja(string nome)
        {
            country.COUNTRY_NAME = nome;
        }
        
        [Given(@"a REGION_ID sejá (.*)")]
        public void DadoAREGION_IDSeja(int regId)
        {
            country.REGION_ID = regId;
        }
        
        [When(@"eu salvar")]
        public void QuandoEuSalvar()
        {
            country.SetValidator(_containerContext.GetService<IValidator<COUNTRy>>());
            country.IsValidToAdd();
        }
        
        [Then(@"a validação deve ser verdadeira")]
        public void EntaoAValidacaoDeveSerVerdadeira()
        {   
            Assert.AreEqual(true, country.ValidationResult.IsValid);
        }
    }
}
