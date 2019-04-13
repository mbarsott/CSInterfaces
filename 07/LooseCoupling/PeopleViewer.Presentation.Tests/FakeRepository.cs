using Common;
using System;
using System.Collections.Generic;

namespace PeopleViewer.Presentation.Tests
{
    public class FakeRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            return TestData.testPeople;
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }
    }
}
