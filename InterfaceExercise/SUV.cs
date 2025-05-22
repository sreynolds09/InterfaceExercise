using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public double WheelSize { get; set; } = 15.6;
        public bool HasFlatBed { get; set; } = true;
        public bool HasFourWheelDrive { get; set; } = false;
        public bool IsDriveable { get; set; } = true;
        public string Model { get; set; } = "Nissan";
        public string Make { get; set; } = "Pathfinder";
        public int NumberOfWheels { get; set; } = 4; 
        public bool HasChangedGears { get; set; }
        public bool HasTrunk { get; set; } = true;

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"The {Make} {Model} has four-wheel drive and is now driving forward.");
                
            }
            else
            {
                Console.WriteLine($"The {Make} {Model} is now driving forward.");
            }
            
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {Make} {Model} is now reversing");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {Make} {Model} is now in park");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("You must change gears in order to leave Park.");
            }
            
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

       public void Trunk(bool containsTrunk)
        {
            if (containsTrunk == true)
            {Console.WriteLine($"The {Make} {Model} contains a trunk");}
            else
            {
                Console.WriteLine($"The {Make} {Model} does not contain a trunk.");
            }
            HasTrunk = containsTrunk;
        }

        public string ManufacturerName { get; set; }
        public string CompanyLocation { get; set; }
    }
}