using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SampleDotNetCore2RestStub.Models;
using SampleDotNetCore2RestStub.Repositories;

namespace SampleDotNetCore2RestStub.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet("person/get/{id}")]
        public Person GetPerson(int id)
        {
            return PersonRepository.GetById(id);
        }

        [HttpGet("person/remove")]
        public string RemovePerson()
        {
            PersonRepository.Remove();
            return "Last person remove. Total count: " + PersonRepository.GetCount();
        }

        [HttpGet("person/all")]
        public List<Person> GetPersons()
        {
            return PersonRepository.GetAll();
        }

        [HttpPost("person/save")]
        public string AddPerson(Person person)
        {
            return PersonRepository.Save(person);
        }
    }
}
