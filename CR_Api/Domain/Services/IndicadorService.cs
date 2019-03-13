using Domain.Entities;
using Domain.Interfaces.Services;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;
using TCE.Repository.Interfaces;
using System.Linq;

namespace Domain.Services
{
    public class IndicadorService : ServiceBase<Indicador>, IIndicadorService
    {
        public IndicadorService(IEFRepositoryBase<Indicador> repository) : base(repository)
        {
        }

        public Indicador GetIndicador(long id)
        {
            return GetSingle((int)id);
        }

        public Indicador GetEmAnalise()
        {
            return GetSingle(a => a.SglIndicador == "ANA" && a.TipoIndicador.NomTipoIndicador == "SITUACAO");
        }

        public Indicador GetProcessando()
        {
            return GetSingle(a => a.SglIndicador == "PRO" && a.TipoIndicador.NomTipoIndicador == "SITUACAO");
        }

        public Indicador GetRecusado()
        {
            return GetSingle(a => a.SglIndicador == "REC" && a.TipoIndicador.NomTipoIndicador == "SITUACAO");
        }

        public Indicador GetConcluido()
        {
            return GetSingle(a => a.SglIndicador == "CON" && a.TipoIndicador.NomTipoIndicador == "SITUACAO");
        }

        public IEnumerable<Indicador> GetAllCategoria()
        {
            return GetAllByNomeTipoIndicador("CATEGORIA");
        }

        public IEnumerable<Indicador> GetAllSituacao()
        {
            return GetAllByNomeTipoIndicador("SITUACAO");
        }

        public IEnumerable<Indicador> GetAllStatus()
        {
            return GetAllByNomeTipoIndicador("STATUS");
        }

        private IEnumerable<Indicador> GetAllByNomeTipoIndicador(string nomTipoIndicador)
        {
            return _repository.All().Where(i => i.TipoIndicador.NomTipoIndicador == nomTipoIndicador);
        }
    }
}
