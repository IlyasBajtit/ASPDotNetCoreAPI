using Exercice01API.Models;
using System.Linq.Expressions;

namespace Exercice01API.Repositories
{
    public interface ContactRepository : IRepository<Contact>
    {
        public bool Add(Contact entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Contact? Get(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll(Expression<Func<Contact, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Contact? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
