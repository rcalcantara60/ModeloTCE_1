using AutoMapper;


namespace Application.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg => cfg.AddProfiles(new[]
            {
                "Application", "Dto", "AcL"
            }));
        }
    }
}
