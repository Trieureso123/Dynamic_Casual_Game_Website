using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IFeedbackRepositories : IBaseRepository<Feedback>
    {

    }

    public class FeedbackRepositories : IFeedbackRepositories
    {
        private readonly GameWebsiteDbContext _context;

        public FeedbackRepositories(GameWebsiteDbContext context)
        {
            _context = context;
        }

        public Feedback Create(Feedback entity)
        {
            throw new NotImplementedException();
        }

        public Feedback Delete(Feedback entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Feedback> Get()
        {
            return _context.Feedbacks;
        }

        public IQueryable<Feedback> Get(Expression<Func<Feedback, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Feedback Get<TKey>(TKey id)
        {
            throw new NotImplementedException();
        }

        public Task<Feedback> GetAsync<TKey>(TKey id)
        {
            throw new NotImplementedException();
        }

        public Feedback Update(Feedback entity)
        {
            throw new NotImplementedException();
        }
    }
}
