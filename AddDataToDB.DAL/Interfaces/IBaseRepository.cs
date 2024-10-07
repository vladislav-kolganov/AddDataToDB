using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDataToDB.DAL.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        IQueryable<TEntity> GetAll(); // select - извлеение записей из бд

        Task<TEntity> CreateAsync(TEntity entity); // insert

        Task<TEntity> UpdateAsync(TEntity entity); // update 

        Task<TEntity> RemoveAsync(TEntity entity);  // delete
    }
}
