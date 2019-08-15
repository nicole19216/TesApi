using System;
using System.Collections.Generic;
using System.Text;

namespace Contract
{
    public interface IRepositoryWrapper
    {
        INumberRepository Number { get; }
        IDireccionRepository Direccion { get; }
        void Save();
    }
}
