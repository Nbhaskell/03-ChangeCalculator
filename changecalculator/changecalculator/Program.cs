using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace changecalculator
{
    class Program
    {
        static decimal Cost(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    string entry = Console.ReadLine();
                    decimal x = decimal.Parse(entry);
                    if (x > 0)
                    {
                        return x;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("enter to correct amount of money");
                }
            }
        }
        static decimal Cash(string prompt)
        {


            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    string userInput = Console.ReadLine();
                    decimal x = decimal.Parse(userInput);
                    if (x > 0)
                    {
                        return x;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter the correct amount of money you have received from the customer.");
                }

            }
        }


        static void Main(string[] args)
        {
            decimal cost = Cost("What is the cost of the item?");
            decimal cash = Cash("How much did the customer give?");
            decimal x = cash;

            while (cost > cash)
            {
                Console.WriteLine("Customer didn't give enough money.");
            }
            if (cash >= cost)
            {
                decimal change = Math.Round(cash - cost, 2);
                decimal quarters = Math.Floor(change / .25m);
                decimal quartersR = (change % .25m);
                decimal dimes = Math.Floor(quartersR / .10m);
                decimal dimesR = (quartersR % .10m);
                decimal nickels = Math.Floor(dimesR % .05m);
                decimal nickelsR = (dimesR % .05m);
                decimal pennies = (nickelsR / .01m);

                Console.WriteLine("Total change = " + change + " paid to customer");
                Console.WriteLine("Give customer " + quarters + " quarters.");
                Console.WriteLine("Give customer " + dimes + " dimes.");
                Console.WriteLine("Give customer " + nickels + " nickels.");
                Console.WriteLine("Give customer " + pennies + " pennies");
                Console.ReadKey();
            }
        }
    }
}