using Examples.Charge.Domain.Aggregates.Common.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.Common.Services
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        protected readonly IBaseRepository<TEntity> Repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            Repository = repository;
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await Repository.GetAll();
        }

        public virtual async Task<TEntity> GetById(object id)
        {
            return await Repository.GetById(id);
        }

        public virtual async Task Create(TEntity obj)
        {
            await Repository.Add(obj);
        }

        public virtual async Task Update(TEntity obj)
        {
            await Repository.Update(obj);
        }

        public virtual async Task Delete(TEntity obj)
        {
            await Repository.Remove(obj);
        }

        public virtual void Dispose()
        {
            Repository.Dispose();
        }
    }
}
