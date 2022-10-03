using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Repositories
{
    public interface IDescriptionRepository : IBaseRepository<Description>
    {

    }

    public class DescriptionRepository : BaseRepository<Description>, IDescriptionRepository
    {
        private readonly IHttpClientFactory _clientFactory;

        public DescriptionRepository(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }
    }
}
