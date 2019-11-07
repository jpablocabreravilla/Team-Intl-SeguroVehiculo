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
    public class AddModel : PageModel
    {
        public PersonStore PersonStore { get; set; }
        public AddModel(PersonStore personStore)
        {
            PersonStore = personStore;
        }

        [BindProperty]
        public Person Person { get; set; }

        public IActionResult OnPostAsync()   //ADD
        {
            PersonStore.AddPerson(Person);
            return RedirectToPage("./Index");
        }
        public void OnGet()
        {
        }
    }
}
