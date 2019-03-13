using Application.Dto.Comum;
using System;

namespace Application.Dto
{
    public class CountryDto : EntityBaseDto
    {
        public string COUNTRY_ID { get; set; }
        public string COUNTRY_NAME { get; set; }
        public decimal? REGION_ID { get; set; }

        public CountryDto()
        {

        }
    }
}
