using Contract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private Tesis004Context _repoContext;
        private INumberRepository _number;
        private IDireccionRepository _direccion;

        public INumberRepository Number
        {
            get
            {
                if (_number == null)
                {
                    _number = new NumberRepository(_repoContext);
                }

                return _number;
            }
        }

        public IDireccionRepository Direccion
        {
            get
            {
                if (_direccion == null)
                {
                    _direccion = new DireccionRepository(_repoContext);
                }

                return _direccion;
            }
        }

        public RepositoryWrapper(Tesis004Context repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
