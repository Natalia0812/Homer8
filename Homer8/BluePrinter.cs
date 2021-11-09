using System;
using System.Collections.Generic;
using System.Text;

namespace Homer8
{
    class BluePrinter : Printer
    {
        public BluePrinter()
        {
            Console.WriteLine("inside BluePrinter constructor");
        }
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("printing in blue: " + value);
            Console.ResetColor();
        }

        public override string ToString()
        {
            return "Blue printer";
        }
    }
}
