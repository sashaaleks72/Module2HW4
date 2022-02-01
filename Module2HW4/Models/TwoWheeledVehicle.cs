namespace Module2HW4
{
    public abstract class TwoWheeledVehicle : Vehicle
    {
        public TwoWheeledVehicle()
        {
        }

        public TwoWheeledVehicle(double weight, double maxSpeed, double sizeOfWheels)
            : base(weight, maxSpeed)
        {
            SizeOfWheels = sizeOfWheels;
        }

        private double SizeOfWheels { get; set; }
    }
}
