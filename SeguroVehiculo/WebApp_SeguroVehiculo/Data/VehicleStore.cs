using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_SeguroVehiculo.Models;

namespace WebApp_SeguroVehiculo.Data
{
	public class VehicleStore
	{
		public SVContext Context { get; set; }

		public VehicleStore(SVContext context)
		{
			Context = context;
		}
		internal void EditVehiculo(Vehicle vehicle)
		{
			var currentvehicle = GetVehicleById(vehicle.Id);
			currentvehicle.Id = vehicle.Id;
			currentvehicle.Brand = vehicle.Brand;
			currentvehicle.Model = vehicle.Model;
			currentvehicle.Year = vehicle.Year;
			currentvehicle.PersonId = vehicle.PersonId;

			Context.Vehicle.Update(currentvehicle);
			Context.SaveChanges();

		}

		internal Vehicle GetVehicleById(Guid id)
		{
			return Context.Vehicle.FirstOrDefault(x => x.Id == id);
		}

		internal void AddVehicle(Vehicle vehicle)
		{
			Context.Vehicle.Add(vehicle);
			Context.SaveChanges();
		}

		internal void DeleteVehicle(Guid id)
		{
			var Vehicle = Context.Vehicle.FirstOrDefault(x => x.Id == id);
			Context.Remove(Vehicle);
			Context.SaveChanges();
		}

		public List<Vehicle> GetVehicles()
		{
			return Context.Vehicle.ToList();
		}

	}
}
