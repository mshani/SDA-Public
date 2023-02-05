using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageExample
{
    public static class Menu
    {
        //Test comment
        public static void PrintMenu()
        {
            Console.WriteLine("Type 'A' to create a new storage");
            Console.WriteLine("Type 'B' to print values");
            Console.WriteLine("Type 'C' to find keys");
            Console.WriteLine("Type 'EXIT' to close the app");
        }

        public static void ExecuteOption(string option, Storage storage)
        {
            option = option.ToUpper().Trim();
            switch (option) { 
                case "A":
                    ExecuteA(storage);
                    break;
                case "B":
                    ExecuteB(storage);
                    break; 
                case "C":
                    ExecuteC(storage);
                    break;
                case "MENU":
                    PrintMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    Console.Clear();
                    break;
                
            }
        }

        private static void ExecuteA(Storage storage)
        {
            Console.WriteLine("Enter key");
            var key = Console.ReadLine();
            Console.WriteLine("Enter value");
            var value = Console.ReadLine();
            storage.AddStorage(key.Trim(), value.Trim());
            Console.Clear();
        }

        private static void ExecuteB(Storage storage)
        {
            Console.WriteLine("Enter key");
            var k = Console.ReadLine();
            storage.PrintValues(k.Trim());
            Console.Clear();
        }

        private static void ExecuteC(Storage storage)
        {
            Console.WriteLine("Enter value");
            var v = Console.ReadLine();
            var keys = storage.FindKeys(v.Trim());
            foreach (var element in keys)
            {
                Console.WriteLine(element);
            }
            Console.Clear();
        }
    }
}
