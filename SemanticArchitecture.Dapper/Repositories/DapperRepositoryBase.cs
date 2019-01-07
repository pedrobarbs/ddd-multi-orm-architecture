using Microsoft.Extensions.Configuration;
using SemanticArchitecture.Domain.Core.Repository_Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SemanticArchitecture.DataAccess.Dapper.Repositories
{
    public abstract class DapperRepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        #region variables
        private static string _connectionString;
        protected readonly IConfiguration _configuration;
        protected readonly string _entity;
        #endregion

        #region Constructos
        public DapperRepositoryBase(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _connectionString ?? configuration.GetConnectionString("SemanticArchitecture");
        }
        #endregion

        #region Utility Method
        protected readonly Action<Action<SqlConnection>> DbConnect = (action) =>
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                action(conn);
            }
        };
        #endregion

        #region Methods
        public abstract void Add(TEntity obj);
        public abstract IEnumerable<TEntity> GetAll();
        public abstract TEntity GetById(Guid id);
        public abstract void Remove(TEntity obj);
        public abstract void Update(TEntity obj);
        #endregion
    }
}
