using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SampleDotNetCore2RestStub.Models;
using SampleDotNetCore2RestStub.Repositories;

namespace SampleDotNetCore2RestStub.Controllers
{
    public class PersonController : Controller
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet("person/get/{id}")]
        public Person GetPerson(int id)
        {
            return _personRepository.GetById(id);
        }

        [HttpGet("person/remove")]
        public string RemovePerson()
        {
            _personRepository.Remove();
            return "Last person remove. Total count: " + _personRepository.GetCount();
        }

        [HttpGet("person/all")]
        public List<Person> GetPersons()
        {
            return _personRepository.GetAll();
        }

        [HttpPost("person/save")]
        public string AddPerson([FromBody]Person person)
        {
            return _personRepository.Save(person);
        }
    }
}
