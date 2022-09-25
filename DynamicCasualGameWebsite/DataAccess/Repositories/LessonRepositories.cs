using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface ILessonRepositories : IBaseRepository<Lesson>
    {

    }

    public class LessonRepositories : ILessonRepositories
    {
        private readonly GameWebsiteDbContext _context;
        public LessonRepositories(GameWebsiteDbContext context)
        {
            _context = context;
        }

        public Lesson Create(Lesson entity)
        {
            throw new NotImplementedException();
        }

        public Lesson Delete(Lesson entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Lesson> Get()
        {
            return _context.Lessons;
        }

        public IQueryable<Lesson> Get(Expression<Func<Lesson, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Lesson Get<TKey>(TKey id)
        {
            return _context.Lessons.Find(id);
        }

        public Task<Lesson> GetAsync<TKey>(TKey id)
        {
            throw new NotImplementedException();
        }

        public Lesson Update(Lesson entity)
        {
            throw new NotImplementedException();
        }
    }
}
