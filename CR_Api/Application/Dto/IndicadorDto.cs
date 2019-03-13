using Application.Dto.Comum;

namespace Application.Dto
{
    public class IndicadorDto : EntityBaseDto
    {
        public long IdTipoIndicador { get; set; }
        public virtual TipoIndicadorDto TipoIndicadorDto { get; set; }
        public string SglIndicador { get; set; }
        public string DscIndicador { get; set; }

        public IndicadorDto()
        {

        }
    }
}
