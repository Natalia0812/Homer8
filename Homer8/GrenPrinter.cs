using System;
using System.Collections.Generic;
using System.Text;

namespace Homer8
{
    class GrenPrinter : Printer
    {
        public GrenPrinter()
        {
            Console.WriteLine("inside GreenPrinter constructor");
        }
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("printing in green: " + value);
            Console.ResetColor();
        }

        public override string ToString()
        {
            return "green printer";
        }
    }
}
