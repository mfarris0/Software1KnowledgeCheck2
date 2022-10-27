using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software1KnowledgeCheck2.Business;

namespace Software1KnowledgeCheck2.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
            Console.ReadLine();
        }

        static void Run()
        {
            DisplayHeader();

            var numberOfRecords = int.Parse(Console.ReadLine());
            Console.WriteLine();


            var printerList = new List<Printer>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                int printerCount = i + 1;
                Console.WriteLine($"Enter values for printer {printerCount}");
                var printer = new Printer();

                Console.Write($"Manufacturer: ");
                printer.Manufacturer = Console.ReadLine();

                Console.Write($"Model Number: ");
                printer.ModelNumber = Console.ReadLine();

                Console.Write($"Printed Pages per Minute: ");
                printer.PrintedPagesPerMinute = int.Parse( Console.ReadLine());

                Console.WriteLine();

                printerList.Add(printer);
            }

            DisplayList(printerList);
        }

        private static void DisplayList(List<Printer> printerList)
        {
            Console.Clear();
            Console.WriteLine("*** Printer Inventory Report ***");
            foreach (var item in printerList)
            {
                Console.WriteLine( item.ToString());
                if (printerList.Count > 1) Console.WriteLine();
            }
        }

        private static void DisplayHeader()
        {
            Console.WriteLine("*** This program will record your printer inventory ***");
            Console.WriteLine("Fields records are Manufacturer, Model Number. and Printed Pages per Minute");
            Console.WriteLine();
            Console.WriteLine("How many records do you want to add? ");
            Console.WriteLine();
        }
    }
}
