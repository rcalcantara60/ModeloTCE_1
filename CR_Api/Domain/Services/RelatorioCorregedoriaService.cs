using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Interfaces;
using System.Linq;

namespace Domain.Services
{
    public class RelatorioCorregedoriaService : ServiceBase<RelatorioCorregedoria>, IRelatorioCorregedoriaService
    {
        public RelatorioCorregedoriaService(IEFRepositoryBase<RelatorioCorregedoria> repository) : base(repository)
        {
        }

        public IEnumerable<RelatorioCorregedoria> GetAll(string Tipo, string Ano, string Mes, string Trimestre)
        {
            var resposta = _repository.All();

            int ano;
            if (!string.IsNullOrEmpty(Ano))
                if (int.TryParse(Ano.ToString(), out ano))
                    resposta = resposta.Where(t => t.Ano == ano);

            if (!string.IsNullOrEmpty(Tipo))
            {
                if (Tipo.ToUpper() == "MENSAL")
                {
                    resposta = resposta.Where(t => t.Mensal == true);
                    int mes;
                    if (!string.IsNullOrEmpty(Mes))
                        if (int.TryParse(Mes.ToString(), out mes))
                            resposta = resposta.Where(t => t.Mes == mes);
                }
                else if (Tipo.ToUpper() == "TRIMESTRAL")
                {
                    resposta = resposta.Where(t => t.Trimestral == true);
                    int trimestre;
                    if (!string.IsNullOrEmpty(Trimestre))
                        if (int.TryParse(Trimestre.ToString(), out trimestre))
                            resposta = resposta.Where(t => t.Trimestre == trimestre);
                }
                else if (Tipo.ToUpper() == "ANUAL")
                {
                    resposta = resposta.Where(t => t.Anual == true);
                }
            }

            return resposta;
        }
    }
}
