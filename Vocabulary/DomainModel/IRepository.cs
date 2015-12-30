using System.Collections.Generic;

namespace Vocabulary.DomainModel
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        
        long Add(T entity);
        void Update(T entity);
        void Delete(long id);
    }
}