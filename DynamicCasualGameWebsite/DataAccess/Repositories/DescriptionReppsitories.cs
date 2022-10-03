using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IDescriptionRepositories : IBaseRepository<Description>
    {

    }

    public class DescriptionReppsitories : IDescriptionRepositories
    {
        private readonly GameWebsiteDbContext _context;
        public DescriptionReppsitories(GameWebsiteDbContext context)
        {
            _context = context;
        }

        public Description Create(Description entity)
        {
            throw new NotImplementedException();
        }

        public Description Delete(Description entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Description> Get()
        {
            return _context.Descriptions;
        }

        public IQueryable<Description> Get(Expression<Func<Description, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Description Get<TKey>(TKey id)
        {
            throw new NotImplementedException();
        }

        public Task<Description> GetAsync<TKey>(TKey id)
        {
            throw new NotImplementedException();
        }

        public Description Update(Description entity)
        {
            throw new NotImplementedException();
        }
    }
}
