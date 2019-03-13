using System;
using System.Collections.Generic;
using TCE.DomainLayerBase.Base;

namespace Domain.Interfaces.Services.Comum
{
    public interface IServiceBaseLocal<T> : IServiceBase<T> where T : class
    {        
    }
}
