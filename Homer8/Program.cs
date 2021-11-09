using System;

namespace Homer8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Room room = new Room();
            BluePrinter bluePrinter = new BluePrinter();
            room.InstallPrinter(bluePrinter);
            room.MakeThisLaziPrinterWork("Hello World!");
            room.printer = new GrenPrinter();
            room.MakeThisLaziPrinterWork("Goodbye!");

            MoneyPrinter dollarBillsPrinter = new MoneyPrinter();
            room.InstallPrinter(dollarBillsPrinter);
            room.MakeThisLaziPrinterWork("lots of money!!!");
        }
    }
}
