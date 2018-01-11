using Microsoft.Extensions.DependencyInjection;
using SampleDotNetCore2RestStub.Repositories;

namespace SampleDotNetCore2RestStub.Integration.Test.Mocks
{
    public class StartupStub : Startup
    {
        public override void ConfigureRepositories(IServiceCollection services)
        {
            services.AddSingleton<IPersonRepository, PersonRepositoryStub>();
        }
    }
}