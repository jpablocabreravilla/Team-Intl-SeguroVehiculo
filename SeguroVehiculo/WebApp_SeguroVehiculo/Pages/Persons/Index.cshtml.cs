using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_SeguroVehiculo.Data;
using WebApp_SeguroVehiculo.Models;

namespace WebApp_SeguroVehiculo.Pages.Persons
{
    public class IndexModel : PageModel
    {
        public PersonStore PersonStore { get; set; }
        public List<Person> Persons { get; set; }

        public IndexModel(PersonStore _personStore)
        {
            PersonStore = _personStore;
            Persons = _personStore.GetPerson();
        }

        public IActionResult OnPostDelete(Guid id)
        {
            PersonStore.DeletePerson(id);
            return RedirectToPage();
        }

        public void OnGet()
        {
        }
    }
}
