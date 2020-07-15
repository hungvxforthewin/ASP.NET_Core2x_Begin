using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DILifeTimeEX.Services
{
    public class ProductService : ITransientService, IScopeService, IInstanceService
    {
        Guid _guid;
        public ProductService()
        {
            _guid = Guid.NewGuid();
        }
        public Guid GetID()
        {
            return _guid;
        }
    }
}
