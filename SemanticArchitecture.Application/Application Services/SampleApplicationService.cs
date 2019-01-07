using SemanticArchitecture.Application.Application_Services_Interfaces;
using SemanticArchitecture.Domain.Core.Domain_Entities;
using SemanticArchitecture.Domain.Domain_Services_Interfaces;

namespace SemanticArchitecture.Application.Application_Services
{
    public class SampleApplicationService : ApplicationServiceBase<Sample>, ISampleApplicationService
    {
        private readonly ISampleService _sampleService;
        public SampleApplicationService(ISampleService sampleService) : base(sampleService)
        {
            _sampleService = sampleService;
        }
    }
}
