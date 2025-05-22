namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool IsDriveable { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasChangedGears { get; set; }
        public bool HasTrunk { get; set; } 
        
        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);
        public void Trunk(bool containsTrunk);


    }
}