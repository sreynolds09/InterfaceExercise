using System;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool IsDriveable { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasTrunk { get; set; }
        public bool IsElectric { get; set; }
        public int NumberOfDoors { get; set; }

        public string ManufacturerName { get; set; }
        public string CompanyLocation { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"[Car]: {Make} {Model} |Wheels: {NumberOfWheels} | Trunk: {HasTrunk} |Elecric: {IsElectric} |Drivable: {IsDriveable} |Number of Doors {NumberOfDoors} |Manufacturer: {ManufacturerName} | CompanyLocation: {CompanyLocation}");
        }

    }
}