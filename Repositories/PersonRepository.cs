using System.Collections.Generic;
using System.Linq;
using SampleDotNetCore2RestStub.Models;

namespace SampleDotNetCore2RestStub.Repositories
{
    public class PersonRepository
    {
        private static Dictionary<int, Person> PERSONS = new Dictionary<int, Person>();

        static PersonRepository()
        {
            PERSONS.Add(1, new Person { Id = 1, FirstName = "FN1", LastName = "LN1", Email = "email1@email.na" });
            PERSONS.Add(2, new Person { Id = 2, FirstName = "FN2", LastName = "LN2", Email = "email2@email.na" });
            PERSONS.Add(3, new Person { Id = 3, FirstName = "FN3", LastName = "LN3", Email = "email3@email.na" });
            PERSONS.Add(4, new Person { Id = 4, FirstName = "FN4", LastName = "LN4", Email = "email4@email.na" });
        }

        public static Person GetById(int id)
        {
            return PERSONS[id];
        }

        public static List<Person> GetAll()
        {
            return PERSONS.Values.ToList();
        }

        public static int GetCount()
        {
            return PERSONS.Count();
        }

        public static void Remove()
        {
            if (PERSONS.Keys.Any())
            {
                PERSONS.Remove(PERSONS.Keys.Last());
            }
        }

        public static string Save(Person person)
        {
            var result = "";
            if (PERSONS.ContainsKey(person.Id))
            {
                result = "Updated Person with id=" + person.Id;
            }
            else
            {
                result = "Added Person with id=" + person.Id;
            }
            PERSONS.Add(person.Id, person);
            return result;
        }
    }
}