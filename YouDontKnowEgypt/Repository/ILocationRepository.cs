using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouDontKnowEgypt.Models;
using YouDontKnowEgypt.Models.Pagination;

namespace YouDontKnowEgypt.Repository
{
    public interface ILocationRepository:IRepositoryBase<Location>
    {
        Task<PagedList<Location>> getLocations(PagingParameters pagingParameters);
    }
}
