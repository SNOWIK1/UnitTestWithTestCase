using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMathNamespace;

namespace ConsoleApp
{
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of one edge: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Volume of cube with edge {userInput} = {MyMath.Volume(userInput)}");

            Console.ReadKey();
        }
    }
}
