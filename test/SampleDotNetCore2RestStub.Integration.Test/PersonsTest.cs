using System.Net;
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
    public class PersonsTest : BaseTest
    {
        [TestMethod]
        public async Task GetPerson()
        {
            var response = await PersonServiceClient.GetPerson("1");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("Stubbed LN1", response.Result.LastName);
        }

        [TestMethod]
        public async Task GetPersons()
        {
            var response = await PersonServiceClient.GetPersons();

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(1, response.Result.Count);
            Assert.AreEqual("Stubbed LN1", response.Result[0].LastName);
        }
    }
}
