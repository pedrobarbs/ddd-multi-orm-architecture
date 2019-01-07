using Dapper.FluentMap;
using SemanticArchitecture.DataAccess.Dapper.Dapper_Maps;

namespace SemanticArchitecture.RegistrationTools
{
    public class DapperRegistration
    {
        public static void RegisterMaps()
        {
            #region Value Objects
            #endregion

            #region Entities
            FluentMapper.Initialize(config => config.AddMap(new SampleMap()));
            #endregion
        }
    }
}
