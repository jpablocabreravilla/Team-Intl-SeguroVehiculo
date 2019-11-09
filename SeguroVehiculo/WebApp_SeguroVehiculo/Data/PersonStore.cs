using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_SeguroVehiculo.Models;

namespace WebApp_SeguroVehiculo.Data
{
    public class PersonStore 
    {
		//public List<Person> Persons { get; set; } = new List<Person>();

		public SVContext Context { get; set; }

		public PersonStore(SVContext context)
        {
			Context = context;
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
			Context.Person.Update(currentperson);
			Context.SaveChanges();

		}

		internal Person GetPersonById(Guid id)
        {
            return Context.Person.FirstOrDefault(x => x.Id == id);
        }

        internal void AddPerson(Person person)
        {
			Context.Person.Add(person);
			Context.SaveChanges();
        }

        internal void DeletePerson(Guid id)
        {
            var Person = Context.Person.FirstOrDefault(x => x.Id == id);
            Context.Remove(Person);
			Context.SaveChanges();
		}

        public List<Person> GetPersons()
        {
			return Context.Person.Include(x => x.Vehicles).ToList();
		}
    }
}
