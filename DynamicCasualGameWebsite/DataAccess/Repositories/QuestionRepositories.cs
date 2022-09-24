using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IQuestionRepository : IBaseRepository<Question>
    {

    }

    public class QuestionRepositories : IQuestionRepository
    {
        private readonly GameWebsiteDbContext _context;

        public QuestionRepositories(GameWebsiteDbContext context)
        {
            _context = context; 
        }

        public Question Create(Question entity)
        {
            throw new NotImplementedException();
        }

        public Question Delete(Question entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Question> Get()
        {
            return _context.Questions;
        }

        public IQueryable<Question> Get(Expression<Func<Question, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Question Get<TKey>(TKey id)
        {
            return _context.Questions.Find(id);
        }

        public Task<Question> GetAsync<TKey>(TKey id)
        {
            throw new NotImplementedException();
        }

        public Question Update(Question entity)
        {
            throw new NotImplementedException();
        }
    }
}
