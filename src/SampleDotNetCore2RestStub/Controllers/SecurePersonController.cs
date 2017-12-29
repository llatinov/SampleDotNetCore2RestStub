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
        private readonly IPersonRepository _personRepository;

        public SecurePersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet("secure/person/all")]
        public List<Person> GetPersons()
        {
            return _personRepository.GetAll();
        }
    }
}
