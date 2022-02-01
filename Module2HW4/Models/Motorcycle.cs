using System;

namespace Module2HW4
{
    public class Motorcycle : Bicycle
    {
        public Motorcycle(double weight, double maxSpeed, double sizeOfWheels)
            : base(weight, maxSpeed, sizeOfWheels)
        {
        }

        public override void Run()
        {
            CurrentSpeed = new Random().Next(Convert.ToInt32(MaxSpeed));
            State = "Moving";
            Console.WriteLine($"Motorcycle is driving about {CurrentSpeed} km/h");
        }

        public override void Stop()
        {
            State = "Staying";
            Console.WriteLine("Motorcycle has been stopped");
        }

        public override string ToString()
        {
            return $"Motorcycle\nMax speed: {MaxSpeed} km/h\nCurrent speed: {CurrentSpeed} km/h\nWeight: {Weight} kg\nSize of wheels: {SizeOfWheels} inches\nState: {State}";
        }
    }
}
