using SemanticArchitecture.Domain.Core.Repository_Interfaces;
using SemanticArchitecture.Domain.Domain_Services_Interfaces;
using System;
using System.Collections.Generic;

namespace SemanticArchitecture.Domain.Domain_Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _respository;

        public ServiceBase(IRepositoryBase<TEntity> respository)
        {
            _respository = respository;
        }

        public void Add(TEntity obj)
        {
            _respository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _respository.GetAll();
        }

        public TEntity GetById(Guid id)
        {
            return _respository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            _respository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _respository.Update(obj);
        }
    }
}
