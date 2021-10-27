using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.Common.Interfaces
{
    public interface IBaseService<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity> GetById(object id);
        Task<List<TEntity>> GetAll();
        Task Create(TEntity obj);
        Task Update(TEntity obj);
        Task Delete(TEntity obj);
    }
}
