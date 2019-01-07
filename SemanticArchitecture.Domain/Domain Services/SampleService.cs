using SemanticArchitecture.Domain.Core.Domain_Entities;
using SemanticArchitecture.Domain.Core.Repository_Interfaces;
using SemanticArchitecture.Domain.Domain_Services_Interfaces;

namespace SemanticArchitecture.Domain.Domain_Services
{
    public class SampleService : ServiceBase<Sample>, ISampleService
    {
        private readonly ISampleRepository _sampleRepository;
        public SampleService(ISampleRepository sampleRepository) : base(sampleRepository)
        {
            _sampleRepository = sampleRepository;
        }
    }
}
