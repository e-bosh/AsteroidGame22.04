using System;

namespace TestConsole
{
    class Printer
    {
        public virtual void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
