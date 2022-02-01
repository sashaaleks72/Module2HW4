namespace Module2HW4
{
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }

        public Vehicle(double weight, double maxSpeed)
        {
            Weight = weight;
            MaxSpeed = maxSpeed;
        }

        public double Weight { get; set; }
        public double MaxSpeed { get; set; }
        public double CurrentSpeed { get; set; }
        public string State { get; set; }
    }
}
