namespace Module2HW4
{
    public static class ArrayExtension
    {
        public static Vehicle SearchVehicleWithTheHighestMaxSpeed(this Vehicle[] vehicles)
        {
            double maxSpeed = 0;
            int? indexOfVehicle = null;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].MaxSpeed > maxSpeed)
                {
                    maxSpeed = vehicles[i].MaxSpeed;
                    indexOfVehicle = i;
                }
            }

            return vehicles[indexOfVehicle.Value];
        }

        public static Vehicle SearchVehicleWithTheHighestCurrentSpeed(this Vehicle[] vehicles)
        {
            double currSpeed = 0;
            int? indexOfVehicle = null;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i].CurrentSpeed > currSpeed)
                {
                    currSpeed = vehicles[i].MaxSpeed;
                    indexOfVehicle = i;
                }
            }

            return vehicles[indexOfVehicle.Value];
        }
    }
}
