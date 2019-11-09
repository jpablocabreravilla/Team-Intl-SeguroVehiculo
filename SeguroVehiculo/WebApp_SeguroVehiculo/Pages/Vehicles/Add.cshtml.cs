using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp_SeguroVehiculo.Data;
using WebApp_SeguroVehiculo.Models;

namespace WebApp_SeguroVehiculo.Pages.Vehicles
{
    public class AddModel : PageModel
    {
		public VehicleStore VehicleStore { get; set; }

		public AddModel(VehicleStore vehicleStore)
		{
			VehicleStore = vehicleStore;
		}

		[BindProperty]
		public Vehicle Vehicle { get; set; }

		[BindProperty]
		public Guid PersonId { get; set; }

		public void OnGet(Guid personid)
		{
			this.PersonId = personid; // Como hago para sacar el guid de person?
		}

		public IActionResult OnPostAsync()
		{
			if (!ModelState.IsValid) // Validacion de que no me mande el Modelo vacio y lo guarde asi
			{
				return Page();
			}
			Vehicle.PersonId = PersonId;
			VehicleStore.AddVehicle(Vehicle);
			return RedirectToPage("./Index");
		}


	}
}