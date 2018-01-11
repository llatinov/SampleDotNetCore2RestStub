using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using SampleDotNetCore2RestStub.Integration.Test.Client;
using SampleDotNetCore2RestStub.Integration.Test.Mocks;
using SampleDotNetCore2RestStub.Repositories;

namespace SampleDotNetCore2RestStub.Integration.Test
{
    public abstract class BaseTest
    {
        protected PersonServiceClient PersonServiceClient;
        protected Mock<IPersonRepository> PersonRepositoryMock;

        public BaseTest()
        {
            PersonRepositoryMock = new Mock<IPersonRepository>();

            var server = new TestServer(new WebHostBuilder()
                .UseStartup<StartupMock>()
                .ConfigureServices(services =>
                {
                    services.AddSingleton(PersonRepositoryMock.Object);
                }));

            var httpClient = server.CreateClient();
            PersonServiceClient = new PersonServiceClient(httpClient);
        }

        [TestCleanup]
        public void BaseTearDown()
        {
            PersonRepositoryMock.Reset();
        }
    }
}