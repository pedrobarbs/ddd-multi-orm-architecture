using SemanticArchitecture.Application.Application_Services_Interfaces;
using SemanticArchitecture.Domain.Domain_Services_Interfaces;
using System;
using System.Collections.Generic;

namespace SemanticArchitecture.Application.Application_Services
{
    public class ApplicationServiceBase<TEntity> : IApplicationServiceBase<TEntity> where TEntity : class
    {
        #region Properties
        private readonly IServiceBase<TEntity> _serviceBase;
        #endregion

        #region Construtors
        public ApplicationServiceBase(IServiceBase<TEntity> serviceBase) => _serviceBase = serviceBase;
        #endregion

        #region Methods
        public void Add(TEntity obj) => _serviceBase.Add(obj);
        public IEnumerable<TEntity> GetAll() => _serviceBase.GetAll();
        public TEntity GetById(Guid id) => _serviceBase.GetById(id);
        public void Remove(TEntity obj) => _serviceBase.Remove(obj);
        public void Update(TEntity obj) => _serviceBase.Update(obj);
        #endregion
    }
}