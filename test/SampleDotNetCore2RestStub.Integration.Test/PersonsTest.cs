using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using SampleDotNetCore2RestStub.Models;

namespace SampleDotNetCore2RestStub.Integration.Test
{
    [TestClass]
    public class PersonsTest : BaseTest
    {
        private readonly Person _person = new Person
        {
            Id = 1,
            FirstName = "Mocked FN1",
            LastName = "Mocked LN1",
            Email = "mocked.email1@email.na"
        };

        [TestMethod]
        public async Task GetPerson_ReturnsCorrectResult()
        {
            PersonRepositoryMock.Setup(x => x.GetById(It.IsAny<int>()))
                .Returns(_person);

            var response = await PersonServiceClient.GetPerson("1");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual("Mocked LN1", response.Result.LastName);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task GetPerson_ThrowsException()
        {
            PersonRepositoryMock.Setup(x => x.GetById(It.IsAny<int>()))
                .Throws(new InvalidOperationException());

            var result = await PersonServiceClient.GetPerson("1");
        }

        [TestMethod]
        public async Task GetPersons()
        {
            PersonRepositoryMock.Setup(x => x.GetAll())
                .Returns(new List<Person> { _person });

            var response = await PersonServiceClient.GetPersons();

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            Assert.AreEqual(1, response.Result.Count);
            Assert.AreEqual("Mocked LN1", response.Result[0].LastName);
        }
    }
}
