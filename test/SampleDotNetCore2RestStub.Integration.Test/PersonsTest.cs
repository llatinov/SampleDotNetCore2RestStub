using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SampleDotNetCore2RestStub.Models;

namespace SampleDotNetCore2RestStub.Integration.Test
{
    [TestClass]
    public class PersonsTest
    {
        private static TestServer _server;
        private static HttpClient _client;

        [ClassInitialize]
        public static void TestInitialize(TestContext context)
        {
            _server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        [TestMethod]
        public async Task GetPerson()
        {
            var response = await _client.GetAsync("/person/get/1");
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var person = JsonConvert.DeserializeObject<Person>(result);

            Assert.AreEqual("LN1", person.LastName);
        }
    }
}
