using System;

namespace Module2HW4
{
    internal class Starter
    {
        public Starter(IMessage message, IBicycle bicycle, IMotorcycle motorcycle)
        {
            Message = message;
            BicycleService = bicycle;
            MotorcycleService = motorcycle;
        }

        private IMessage Message { get; set; }
        private IBicycle BicycleService { get; set; }
        private IMotorcycle MotorcycleService { get; set; }

        public void Run()
        {
            IMovable bicycle = new Bicycle(12, 60, 27.5, SizeOfFrame.M);
            IMovable motorcycle = new Motorcycle(150, 200, 4.5);

            Message.ShowMsg($"Bicycle");
            BicycleService.Move((Bicycle)bicycle);

            Message.ShowMsg($"Motorcycle");
            MotorcycleService.Move((Motorcycle)motorcycle);

            Console.WriteLine(bicycle);
            Console.WriteLine();
            Console.WriteLine(motorcycle);
            Console.WriteLine();

            Vehicle[] vehicles = { (Bicycle)bicycle, (Motorcycle)motorcycle };

            var vehicle = vehicles.SearchVehicleWithTheHighestMaxSpeed();

            Message.ShowMsg("Vehicle with the most highest max speed: ");
            if (vehicle is Motorcycle)
            {
                Console.WriteLine(motorcycle);
            }
            else
            {
                Console.WriteLine(bicycle);
            }

            Console.WriteLine();

            vehicle = vehicles.SearchVehicleWithTheHighestCurrentSpeed();

            Message.ShowMsg("Vehicle with the most highest current speed: ");
            if (vehicle is Motorcycle)
            {
                Console.WriteLine(motorcycle);
            }
            else
            {
                Console.WriteLine(bicycle);
            }
        }
    }
}
