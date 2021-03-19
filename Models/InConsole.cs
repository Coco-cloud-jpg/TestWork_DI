using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exoft_Task
{
    public class InConsole : IAnounceMessage
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine($"The message: {msg}");
        }
    }
}
