namespace Module2HW4
{
    public abstract class TwoWheeledVehicle : Vehicle
    {
        private double _sizeOfWheels;

        public TwoWheeledVehicle()
        {
        }

        public TwoWheeledVehicle(double weight, double maxSpeed, double sizeOfWheels)
            : base(weight, maxSpeed)
        {
            _sizeOfWheels = sizeOfWheels;
        }

        public double SizeOfWheels => _sizeOfWheels;
    }
}
