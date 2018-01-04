using Microsoft.Extensions.DependencyInjection;
using SampleDotNetCore2RestStub.Repositories;

namespace SampleDotNetCore2RestStub.Integration.Test.Mocks
{
    public class StartupMock : Startup
    {
        public override void ConfigureRepositories(IServiceCollection services)
        {
            services.AddSingleton<IPersonRepository, PersonRepositoryMock>();
        }
    }
}