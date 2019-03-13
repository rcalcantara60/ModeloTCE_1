using Domain.Entities.Comum;
using LinqToExcel.Attributes;
using System;
using TCE.DomainLayerBase.Base;

namespace Domain.Entities
{
    public class Faq : EntityRegistroArquivo<Faq>
    {
        [ExcelColumn("Pergunta")]
        public string Pergunta { get; set; }
        [ExcelColumn("Resposta")]
        public string Resposta { get; set; }
        public bool Status { get; set; }
        public DateTime DataCadastro { get; set; }

        public override bool IsValidToAdd(IServiceBase<Faq> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToDelete(IServiceBase<Faq> service)
        {
            throw new NotImplementedException();
        }

        public override bool IsValidToUpdade(IServiceBase<Faq> service)
        {
            throw new NotImplementedException();
        }
    }
}
