using Contract;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class NumberRepository : RepositoryBase<tNumero>, INumberRepository
    {
        public NumberRepository(Tesis004Context repositoryContext)
            : base(repositoryContext)
        {
        }
        public IEnumerable<tNumero> GetAllNumbers()
        {
            return FindAll()
                .OrderBy(number => number.Telefono)
                .ToList();
        }
        public tNumero GetNumberById(int numberId)
        {
            return FindByCondition(number => number.IdNumero.Equals(numberId))
                    .FirstOrDefault();
        }
    }
}
