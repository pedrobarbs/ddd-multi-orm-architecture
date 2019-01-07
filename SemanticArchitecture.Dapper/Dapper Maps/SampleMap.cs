using Dapper.FluentMap.Mapping;
using SemanticArchitecture.Domain.Core.Domain_Entities;

namespace SemanticArchitecture.DataAccess.Dapper.Dapper_Maps
{
    public class SampleMap : EntityMap<Sample>
    {
        public SampleMap()
        {
            Map(p => p.Id).ToColumn("ID");
        }
    }
}