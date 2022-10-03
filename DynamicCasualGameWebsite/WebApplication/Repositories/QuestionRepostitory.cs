using System.Net.Http;
using WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Repositories
{
    public interface IQuestionRepository : IBaseRepository<Question>
    {

    }

    public class QuestionRepository : BaseRepository<Question>, IQuestionRepository
    {
        private readonly IHttpClientFactory _clientFactory;

        public QuestionRepository(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }


    }
}
