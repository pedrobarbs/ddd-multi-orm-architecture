using SemanticArchitecture.DataAccess.EntityFramework.Context;
using SemanticArchitecture.DataAccess.EntityFramework.Interfaces;
using SemanticArchitecture.Domain.Core.Domain_Entities;

namespace SemanticArchitecture.DataAccess.EntityFramework.Repositories
{
    public class SampleEFRepository : EFRepositoryBase<Sample>, ISampleEFRepository
    {
        public SampleEFRepository(EntityFrameworkContext context) : base(context)
        {
        }
    }
}
