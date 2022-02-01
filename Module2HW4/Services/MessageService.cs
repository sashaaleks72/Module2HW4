using System;

namespace Module2HW4
{
    public class MessageService : IMessageService
    {
        public void ShowMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
