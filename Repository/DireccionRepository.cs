using Contract;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class DireccionRepository:RepositoryBase<tDireccion>, IDireccionRepository
    {
        public DireccionRepository(Tesis004Context repositoryContext)
            : base(repositoryContext)
    {
    }
}
}
