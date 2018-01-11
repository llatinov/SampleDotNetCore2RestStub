using System.Collections.Generic;
using System.Linq;
using SampleDotNetCore2RestStub.Models;
using SampleDotNetCore2RestStub.Repositories;

namespace SampleDotNetCore2RestStub.Integration.Test.Mocks
{
    public class PersonRepositoryStub : IPersonRepository
    {
        private Dictionary<int, Person> _persons = new Dictionary<int, Person>();

        public PersonRepositoryStub()
        {
            _persons.Add(1, new Person { Id = 1, FirstName = "Stubbed FN1", LastName = "Stubbed LN1", Email = "stubbed.email1@email.na" });
        }

        public Person GetById(int id)
        {
            return _persons[id];
        }

        public List<Person> GetAll()
        {
            return _persons.Values.ToList();
        }

        public int GetCount()
        {
            return _persons.Count();
        }

        public void Remove()
        {
            if (_persons.Keys.Any())
            {
                _persons.Remove(_persons.Keys.Last());
            }
        }

        public string Save(Person person)
        {
            var result = "";
            if (_persons.ContainsKey(person.Id))
            {
                result = "Updated Person with id=" + person.Id;
            }
            else
            {
                result = "Added Person with id=" + person.Id;
            }
            _persons.Add(person.Id, person);
            return result;
        }
    }
}