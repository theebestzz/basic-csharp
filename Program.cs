using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, I'm a simple console application written in C# that can prompt the user for input.");
            Console.WriteLine();
            Console.Write("Please tell me your name: ");

            string name = Console.ReadLine();

            Console.WriteLine();
            if (String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("So you don't have a name? All right, then. Keep your secrets.");
            }
            else
            {
                Console.WriteLine("So your name is " + name.Trim() + ", nice to meet you. Have a great day :)");
            }

            Console.ReadKey();
        }
    }
}
