using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number to multiply: ");
            int number1 = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Enter the second number to multiply: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the third number to multiply: ");
            int number3 = int.Parse(Console.ReadLine());

            int results = number1 * number2 * number3;
            Console.WriteLine("Results: {0} x {1} x {2} = {3}", number1, number2, number3, results);
            Console.ReadKey();
        }
    }
}
