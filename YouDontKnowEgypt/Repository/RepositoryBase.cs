using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouDontKnowEgypt.Models;

namespace YouDontKnowEgypt.Repository
{
    public class RepositoryBase<T>: IRepositoryBase<T> where T:class
    {
        protected YouDontKnowEgyptContext RepositoryContext { get; set; }

        public RepositoryBase (YouDontKnowEgyptContext repositoryContext)
        {
            this.RepositoryContext = repositoryContext;
        }
         
        public IQueryable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>().AsNoTracking();

        }

    }
}
