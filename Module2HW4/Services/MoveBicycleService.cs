using System;

namespace Module2HW4
{
    public class MoveBicycleService : IBicycle
    {
        public MoveBicycleService(IMessage message)
        {
            Message = message;
        }

        public IMessage Message { get; set; }

        public void Move(Bicycle bicycle)
        {
            int choose = 0;

            while (choose != 3)
            {
                Message.ShowMsg("Choose what do you wanna do:\n1.Start moving\n2.Stop moving\n3.I wanna do nothing");
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        bicycle.Run();
                        break;
                    case 2:
                        bicycle.Stop();
                        break;
                    case 3:
                        break;
                    default:
                        bicycle.Run();
                        bicycle.Stop();
                        break;
                }
            }
        }
    }
}
