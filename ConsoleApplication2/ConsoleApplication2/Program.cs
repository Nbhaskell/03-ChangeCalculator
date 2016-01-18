using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} - {1} = {2}", number1, number2, number1-number2);
            

            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1+number2);
            

            Console.WriteLine("{0} * {1} = {2}", number1, number2, number1*number2);
            

            Console.WriteLine("{0} / {1} = {2}", number1, number2, number1/number2);

            Console.WriteLine("{0} % {1} = {2}", number1, number2, number1%number2);
            
            Console.ReadKey();

        }
    }
}
