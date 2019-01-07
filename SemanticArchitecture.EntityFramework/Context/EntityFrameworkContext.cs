using Microsoft.EntityFrameworkCore;
using SemanticArchitecture.Domain.Core.Domain_Entities;

namespace SemanticArchitecture.DataAccess.EntityFramework.Context
{
    public class EntityFrameworkContext : DbContext
    {
        public EntityFrameworkContext(DbContextOptions<EntityFrameworkContext> options) : base(options)
        {
        }

        public DbSet<Sample> Sample { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
