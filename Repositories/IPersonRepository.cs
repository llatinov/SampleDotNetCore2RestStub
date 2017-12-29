using System.Collections.Generic;
using SampleDotNetCore2RestStub.Models;

namespace SampleDotNetCore2RestStub.Repositories
{
    public interface IPersonRepository
    {
        Person GetById(int id);
        List<Person> GetAll();
        int GetCount();
        void Remove();
        string Save(Person person);
    }
}