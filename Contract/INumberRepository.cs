using System;
using System.Collections.Generic;
using System.Text;
using Entities.Models;

namespace Contract
{
    public interface INumberRepository:IRepositoryBase<tNumero>
    {
        IEnumerable<tNumero> GetAllNumbers();
        tNumero GetNumberById(int numberid);
    }
}
