using System.Collections.Generic;
using System.Linq;

namespace MvcAsync.Models
{
    public class PersonRepository
    {
        private readonly List<Person> personData = new List<Person>
        {
            new Person {FirstName = "Adam", LastName = "Freeman", Role = Role.Admin},
            new Person {FirstName = "Steven", LastName = "Sanderson", Role = Role.Admin},
            new Person {FirstName = "Daniel", LastName = "Mackay", Role = Role.User},
            new Person {FirstName = "Jacqui", LastName = "Griffyth", Role = Role.User},
            new Person {FirstName = "Eve-Lyne", LastName = "Rochon", Role = Role.User},
            new Person {FirstName = "John", LastName = "Smith", Role = Role.User},
            new Person {FirstName = "Anne", LastName = "Jones", Role = Role.User},
            new Person {FirstName = "Rod", LastName = "Stewert", Role = Role.User},
            new Person {FirstName = "Tina", LastName = "Turner", Role = Role.User},
            new Person {FirstName = "Bill", LastName = "Murray", Role = Role.User},
            new Person {FirstName = "John", LastName = "Lennon", Role = Role.User},
            new Person {FirstName = "Ringo", LastName = "Star", Role = Role.User},
            new Person {FirstName = "Paul", LastName = "Mcartney", Role = Role.Guest},
            new Person {FirstName = "Hughie", LastName = "Lewis", Role = Role.Guest},
            new Person {FirstName = "The", LastName = "News", Role = Role.Guest},
            new Person {FirstName = "Elton", LastName = "John", Role = Role.Guest},
            new Person {FirstName = "Phil", LastName = "Collins", Role = Role.Guest},
        };

        public List<Person> GetAll()
        {
            return personData;
        }

        public List<Person> GetByRole(Role role)
        {
            return personData.Where(p => p.Role == role).ToList();
        }
    }
}