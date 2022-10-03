using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Repositories
{
    public interface IFeedbackRepository : IBaseRepository<Feedback>
    {

    }

    public class FeedbackRepository : BaseRepository<Feedback>, IFeedbackRepository
    {
        private readonly IHttpClientFactory _clientFactory;

        public FeedbackRepository(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }
    }
}
