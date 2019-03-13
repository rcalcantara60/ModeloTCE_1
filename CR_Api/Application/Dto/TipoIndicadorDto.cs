using Application.Dto.Comum;
using System.Collections.Generic;

namespace Application.Dto
{
    public class TipoIndicadorDto : EntityBaseDto
    {
        public string NomTipoIndicador { get; set; }

        //public virtual ICollection<IndicadorDto> Indicadores { get; set; }

        public TipoIndicadorDto()
        {

        }
    }
}
