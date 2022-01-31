using System;

namespace Module2HW4
{
    public class Bicycle : TwoWheeledVehicle, IMovable
    {
        public Bicycle(double weight, double maxSpeed, double sizeOfWheels)
            : base(weight, maxSpeed, sizeOfWheels)
        {
        }

        public Bicycle(double weight, double maxSpeed, double sizeOfWheels, SizeOfFrame sizeOfFrame)
            : base(weight, maxSpeed, sizeOfWheels)
        {
            SizeOfFrame = sizeOfFrame;
        }

        private SizeOfFrame SizeOfFrame { get; set; }

        public virtual void Run()
        {
            CurrentSpeed = new Random().Next(Convert.ToInt32(MaxSpeed));
            State = "Moving";
            Console.WriteLine($"Bicycle is driving about {CurrentSpeed} km/h");
        }

        public virtual void Stop()
        {
            State = "Staying";
            Console.WriteLine("Bicycle has been stopped");
        }

        public override string ToString()
        {
            string sizeOfFrame;

            sizeOfFrame = SizeOfFrame switch
            {
                SizeOfFrame.S => "S",
                SizeOfFrame.M => "M",
                SizeOfFrame.L => "L",
                SizeOfFrame.XL => "XL",
                _ => "Incorrect value"
            };

            return $"Bicycle\nMax speed: {MaxSpeed} km/h\nCurrent speed: {CurrentSpeed}km/h\nWeight: {Weight} kg\nSize of wheels: {SizeOfWheels} inches\nSize of frame: {sizeOfFrame}\nState: {State}";
        }
    }
}
