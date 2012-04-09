using System.Linq;
using ProductDevelopment.Models;

namespace ProductDevelopment.Web.Infrastructure.Data
{
    public interface IRepository<T> where T : Entity
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Find(int id);
        IQueryable<T> All();
    }
}