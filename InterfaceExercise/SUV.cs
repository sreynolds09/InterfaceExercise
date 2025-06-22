using System;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool HasFourWheelDrive { get; set; }
        public int NumberOfRows { get; set; }
        public bool IsDriveable { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasTrunk { get; set; }
        public string ManufacturerName { get; set; }
        public string CompanyLocation { get; set; }

        public void DisplayDetails()
        {
        Console.WriteLine($"[SUV]: {Make} {Model} | Wheels: {NumberOfWheels} | Rows: {NumberOfRows} | Has Four Wheel Drive: {HasFourWheelDrive} | Drivable: {IsDriveable} | Manufacturer: {ManufacturerName} | CompanyLocation: {CompanyLocation}");
        }
    }
}

       