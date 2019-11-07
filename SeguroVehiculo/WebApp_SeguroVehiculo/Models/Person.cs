using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_SeguroVehiculo.Models
{
    public class Person
    {
        public Person()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }        
        public string Name { get; set; }        
        public string LastName { get; set; }
        public string DocType { get; set; }
        public int DocNum { get; set; }
        //public DateTime BirthDate { get; set; }
        public string BirthDate { get; set; }
        public string City { get; set; }


    }
}
