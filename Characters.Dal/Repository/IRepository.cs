using Characters.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.Dal.Repository
{
    public interface IRepository<T> where T :IEntity, new()
    {
        Task<IList<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);

    }
}
