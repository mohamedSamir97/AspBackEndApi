using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YouDontKnowEgypt.Models;
using YouDontKnowEgypt.Models.Pagination;

namespace YouDontKnowEgypt.Repository
{
    public class LocationRepository : RepositoryBase<Location>, ILocationRepository
    {
        public LocationRepository(YouDontKnowEgyptContext repositoryContext)
            :base(repositoryContext)
        {
            
        }
        public Task<PagedList<Location>> getLocations(PagingParameters pagingParameters)
        {
            return Task.FromResult(PagedList<Location>.GetPagedList(FindAll().Where(s=>s.Approved==true).OrderBy(s => s.Id),
                pagingParameters.PageNumber,pagingParameters.PageSize));
        }
    }
}
