using System;

namespace Module2HW4
{
    public class MessageService : IMessage
    {
        public void ShowMsg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
