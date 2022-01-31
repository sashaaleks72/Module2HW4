using System;

namespace Module2HW4
{
    public class MoveMotorcycleService : IMotorcycle
    {
        public MoveMotorcycleService(IMessage message)
        {
            Message = message;
        }

        private IMessage Message { get; set; }

        public void Move(Motorcycle motorcycle)
        {
            int choose = 0;

            while (choose != 3)
            {
                Message.ShowMsg("Choose what do you wanna do:\n1.Start moving\n2.Stop moving\n3.I wanna do nothing");
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        motorcycle.Run();
                        break;
                    case 2:
                        motorcycle.Stop();
                        break;
                    case 3:
                        break;
                    default:
                        motorcycle.Run();
                        motorcycle.Stop();
                        break;
                }
            }
        }
    }
}
