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
              BirthDate = "15/08/1994",
              City = "Bello"
            });
            Persons.Add(new Person
            {
                Name = "eliza",
                LastName = "acevedo",
                DocType = "CC",
                DocNum = 987,
                BirthDate = "30/11/1995",
                City = "rio negro"
            });
            Persons.Add(new Person
            {
                Name = "miguel",
                LastName = "cabrera",
                DocType = "TI",
                DocNum = 467,
                BirthDate = "2/02/1998",
                City = "Medellin"
            });
        }

        internal void EditPerson(Person person)
        {
            var currentperson = GetPersonById(person.Id);
            currentperson.Id = person.Id;
            currentperson.Name = person.Name;
            currentperson.LastName = person.LastName;
            currentperson.DocNum = person.DocNum;
            currentperson.DocType = person.DocType;
            currentperson.BirthDate = person.BirthDate;
            currentperson.City = person.City;
        }

        internal Person GetPersonById(Guid id)
        {
            return Persons.FirstOrDefault(x => x.Id == id);
        }

        internal void AddPerson(Person person)
        {
            Persons.Add(person);
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
