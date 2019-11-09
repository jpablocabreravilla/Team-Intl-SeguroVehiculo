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
    public class IndexModel : PageModel
    {
		public VehicleStore VehicleStore { get; set; }
		public List<Vehicle> Vehicles { get; set; }

		public IndexModel(VehicleStore _vehicleStore)
		{
			VehicleStore = _vehicleStore;
			Vehicles = _vehicleStore.GetVehicles();
		}

		public IActionResult OnPostDelete(Guid id)
		{
			VehicleStore.DeleteVehicle(id);
			return RedirectToPage();
		}

		public void OnGet()
        {
        }
    }
}
