using Domain.Entities;
using System;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Interfaces.Services
{
    public interface IConcursoService : IServiceBase<Concurso>
    {
        IEnumerable<Concurso> GetAll(int? numero, int? ano, DateTime? dataInicio, DateTime? dataFim);
    }
}
