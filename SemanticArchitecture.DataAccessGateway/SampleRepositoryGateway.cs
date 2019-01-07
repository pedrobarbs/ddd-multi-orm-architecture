using System;
using System.Collections.Generic;
using SemanticArchitecture.DataAccess.EntityFramework.Interfaces;
using SemanticArchitecture.Domain.Core.Domain_Entities;
using SemanticArchitecture.Domain.Core.Repository_Interfaces;

namespace SemanticArchitecture.DataAccessGateway
{
    public class SampleRepositoryGateway : ISampleRepository
    {
        private readonly ISampleDapperRepository _dapper;
        private readonly ISampleEFRepository _entity;

        public SampleRepositoryGateway(ISampleDapperRepository dapper, ISampleEFRepository entity)
        {
            _dapper = dapper;
            _entity = entity;
        }

        public void Add(Sample obj) => _entity.Add(obj);

        public IEnumerable<Sample> GetAll() => _entity.GetAll();

        public Sample GetById(Guid id) => _entity.GetById(id);

        public void Remove(Sample obj) => _entity.Remove(obj);

        public void Update(Sample obj) => _entity.Update(obj);
    }
}