using System;
using System.Collections.Generic;
using System.Text;

namespace Homer8
{
    class MoneyPrinter : Printer
    {
        public MoneyPrinter()
        {
            Console.WriteLine("inside MoneyPrinter constructor");
        }

        public override void Print(string value)
        {
            Console.WriteLine("printing money from blank bills: '" + value + "'");
            String moneyBills = "";
            for (int i = 0; i < value.Length; i++) {
                moneyBills += "$";
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("printing money: " + moneyBills);
            Console.ResetColor();
        }

        public override string ToString()
        {
            return "money printer";
        }
    }
}
