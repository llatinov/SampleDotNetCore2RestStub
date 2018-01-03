using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleDotNetCore2RestStub.Integration.Test.Client;

namespace SampleDotNetCore2RestStub.Integration.Test
{
    public abstract class BaseTest
    {
        protected PersonServiceClient PersonServiceClient;

        public BaseTest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            var httpClient = server.CreateClient();
            PersonServiceClient = new PersonServiceClient(httpClient);
        }
    }
}