using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YouDontKnowEgypt.Repository
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();

           
    }
}
