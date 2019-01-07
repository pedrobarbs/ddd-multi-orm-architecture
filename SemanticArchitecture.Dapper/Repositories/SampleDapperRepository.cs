using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using SemanticArchitecture.DataAccess.EntityFramework.Interfaces;
using SemanticArchitecture.Domain.Core.Domain_Entities;

namespace SemanticArchitecture.DataAccess.Dapper.Repositories
{
    public class SampleDapperRepository : DapperRepositoryBase<Sample>, ISampleDapperRepository
    {
        public SampleDapperRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public override void Add(Sample obj)
        {
            var command = $@"
                INSERT INTO Sample (
                    Id,
                    Title
                ) VALUES (
                    @Id,
                    @Title
                )";

            DbConnect(conn =>
            {
                var commandResult = conn.Execute(command, new
                {
                    obj.Id,
                    obj.Title
                });
            });
        }

        public override IEnumerable<Sample> GetAll()
        {
            IEnumerable<Sample> queryResult = new List<Sample>();
            var query = $@"
                SELECT
                    Id,
                    Title
                FROM
                    Sample";

            DbConnect(conn =>
            {
                queryResult = conn.Query<Sample>(query).AsList();
            });
            return queryResult;
        }

        public override Sample GetById(Guid id)
        {
            Sample queryResult = null;
            var query = $@"
                SELECT
                    Id,
                    Title
                FROM
                    Sample
                WHERE
                    Id = @Id";

            DbConnect(conn =>
            {
                queryResult = conn.Query<Sample>(query, new { Id = id }).FirstOrDefault();
            });
            return queryResult;
        }

        public override void Remove(Sample obj)
        {
            var command = $@"
                DELETE FROM Sample
                WHERE
                Id = @Id";

            DbConnect(conn =>
            {
                var commandResult = conn.Execute(command, new
                {
                    obj.Id
                });
            });
        }

        public override void Update(Sample obj)
        {
            var command = $@"
                UPDATE Sample
                SET
                    Title = @Title
                WHERE
                Id = @Id";

            DbConnect(conn =>
            {
                var commandResult = conn.Execute(command, new
                {
                    obj.Title,
                    obj.Id
                });
            });
        }
    }
}
