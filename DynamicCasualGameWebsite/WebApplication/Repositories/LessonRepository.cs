using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Repositories
{
    public interface ILessonRepository : IBaseRepository<Lesson>
    {

    }

    public class LessonRepository : BaseRepository<Lesson>, ILessonRepository
    {
        private readonly IHttpClientFactory _clientFactory;

        public LessonRepository(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        
    }
}
