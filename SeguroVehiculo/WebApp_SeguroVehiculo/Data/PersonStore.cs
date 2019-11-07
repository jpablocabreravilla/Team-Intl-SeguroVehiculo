using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_SeguroVehiculo.Models;

namespace WebApp_SeguroVehiculo.Data
{
    public class PersonStore 
    {
        public List<Person> Persons { get; set; } = new List<Person>();
        public PersonStore()
        {
            Persons.Add(new Person
            {
             Name = "juan" ,
              LastName = "pablo" ,
              DocType = "CC",
              DocNum = 123,
              City = "Bello"
            });
            Persons.Add(new Person
            {
                Name = "eliza",
                LastName = "acevedo",
                DocType = "CC",
                DocNum = 987,
                City = "rio negro"
            });
            Persons.Add(new Person
            {
                Name = "miguel",
                LastName = "cabrera",
                DocType = "TI",
                DocNum = 467,
                City = "Medellin"
            });
        }

        internal void DeletePerson(Guid id)
        {
            var Person = Persons.FirstOrDefault(x => x.Id == id);
            Persons.Remove(Person);
        }

        public List<Person> GetPerson()
        {
            return this.Persons;
        }
    }
}
