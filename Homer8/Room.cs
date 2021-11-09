using System;
using System.Collections.Generic;
using System.Text;

namespace Homer8
{
    class Room
    {
        public Printer printer { get; set; }
        public Room()
        {
            Console.WriteLine("inside Room constructor");
        }
        
        public void MakeThisLaziPrinterWork(String value)
        {
            printer.Print(value);
        }

        internal void InstallPrinter(Printer printer)
        {
            Console.WriteLine("installing new printer: " + printer);
            this.printer = printer;
        }
    }
}
