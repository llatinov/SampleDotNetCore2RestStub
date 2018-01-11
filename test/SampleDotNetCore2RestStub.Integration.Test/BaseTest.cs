using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleDotNetCore2RestStub.Integration.Test.Client;
using SampleDotNetCore2RestStub.Integration.Test.Mocks;

namespace SampleDotNetCore2RestStub.Integration.Test
{
    public abstract class BaseTest
    {
        protected PersonServiceClient PersonServiceClient;

        public BaseTest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseStartup<StartupStub>());
            var httpClient = server.CreateClient();
            PersonServiceClient = new PersonServiceClient(httpClient);
        }
    }
}