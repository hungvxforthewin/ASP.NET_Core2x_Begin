using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DILifeTimeEX.Services
{
    public interface ITransientService
    {
        Guid GetID();
    }
}
