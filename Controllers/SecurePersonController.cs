using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SampleDotNetCore2RestStub.Attributes;
using SampleDotNetCore2RestStub.Models;
using SampleDotNetCore2RestStub.Repositories;

namespace SampleDotNetCore2RestStub.Controllers
{
    [ServiceFilter(typeof(AuthenticationFilterAttribute))]
    public class SecurePersonController : Controller
    {
        [HttpGet("secure/person/all")]
        public List<Person> GetPersons()
        {
            return PersonRepository.GetAll();
        }
    }
}
