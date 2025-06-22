using System;
using System.ComponentModel.Design;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public double WheelSize { get; set; }
        public bool HasFlatBed { get; set; }
        public bool HasFourWheelDrive { get; set; }
        public bool IsDriveable { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasTrunk { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine($"[Truck]: {Make} {Model} | Wheels: {NumberOfWheels} | Flatbed: {HasFlatBed} | Wheel Size: {WheelSize} in | Drivable: {IsDriveable} | Manufacturer: {ManufacturerName} | CompanyLocation: {CompanyLocation}");
        }

        public string ManufacturerName { get; set; } 
        public string CompanyLocation { get; set; }
        
        
    }
}