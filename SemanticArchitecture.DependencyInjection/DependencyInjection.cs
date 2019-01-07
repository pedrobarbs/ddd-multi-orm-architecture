using Microsoft.Extensions.DependencyInjection;
using SemanticArchitecture.Application.Application_Services;
using SemanticArchitecture.Application.Application_Services_Interfaces;
using SemanticArchitecture.DataAccess.Dapper.Repositories;
using SemanticArchitecture.DataAccess.EntityFramework.Interfaces;
using SemanticArchitecture.DataAccess.EntityFramework.Repositories;
using SemanticArchitecture.DataAccessGateway;
using SemanticArchitecture.Domain.Core.Repository_Interfaces;
using SemanticArchitecture.Domain.Domain_Services;
using SemanticArchitecture.Domain.Domain_Services_Interfaces;

namespace SemanticArchitecture.InversionOfControl
{
    public class DependencyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Sample
            services.AddScoped<ISampleApplicationService, SampleApplicationService>();
            services.AddScoped<ISampleService, SampleService>();
            services.AddScoped<ISampleRepository, SampleRepositoryGateway>();
            services.AddScoped<ISampleDapperRepository, SampleDapperRepository>();
            services.AddScoped<ISampleEFRepository, SampleEFRepository>();
            #endregion
        }
    }
}
