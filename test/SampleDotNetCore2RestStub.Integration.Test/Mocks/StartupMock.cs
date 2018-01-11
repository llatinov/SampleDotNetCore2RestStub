using Microsoft.Extensions.DependencyInjection;
using SampleDotNetCore2RestStub.Repositories;

namespace SampleDotNetCore2RestStub.Integration.Test.Mocks
{
    public class StartupMock : Startup
    {
        private IPersonRepository _personRepository;
        
        public StartupMock(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public override void ConfigureRepositories(IServiceCollection services)
        {
            services.AddSingleton(_personRepository);
        }
    }
}