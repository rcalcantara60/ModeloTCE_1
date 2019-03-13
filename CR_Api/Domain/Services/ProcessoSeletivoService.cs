using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Interfaces;
using System.Linq;
using System;

namespace Domain.Services
{
    public class ProcessoSeletivoService : ServiceBase<ProcessoSeletivo>, IProcessoSeletivoService
    {
        public ProcessoSeletivoService(IEFRepositoryBase<ProcessoSeletivo> repository) : base(repository)
        {
        }

        public IEnumerable<ProcessoSeletivo> GetAll(string numero, string ano, string dataInicio, string dataFim)
        {
            var resposta = _repository.All();
            int ano_convercao, numero_convercao;
            DateTime dataInicio_conversao, dataFim_convercao;

            if (!string.IsNullOrEmpty(ano))
                if (int.TryParse(ano.ToString(), out ano_convercao))
                    resposta = resposta.Where(t => t.Ano == ano_convercao);
            if (!string.IsNullOrEmpty(numero))
                if (int.TryParse(numero.ToString(), out numero_convercao))
                    resposta = resposta.Where(t => t.Numero == numero_convercao);

            if (!string.IsNullOrEmpty(dataInicio))
                if (DateTime.TryParse(dataInicio, out dataInicio_conversao))
                    resposta = resposta.Where(t => t.DataInicio >= dataInicio_conversao);
            if (!string.IsNullOrEmpty(dataFim))
                if (DateTime.TryParse(dataFim, out dataFim_convercao))
                    resposta = resposta.Where(t => t.DataFim <= dataFim_convercao);

            return resposta;
        }
    }
}
