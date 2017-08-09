using System.Collections.Generic;

namespace _03.Detail_Printer
{
    public class Program
    {
        public static void Main()
        {
            Employee manager = new Manager("Mario", new List<string>() { "Pesho.doc", "Ivan.doc" });
            DetailsPrinter printer = new DetailsPrinter(new List<Employee>() { manager });

            printer.printDetails();
        }
    }
}