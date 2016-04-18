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
                Console.WriteLine("Customer didn't give you enough money.");
            }
            if (cash >= cost)
            {
                decimal change = Math.Round(cash - cost, 2);
                decimal dollars = Math.Round(change / 1.0m);
                decimal dollarsR = (change % 1.0m);
                decimal quarters = Math.Floor(dollarsR / .25m);
                decimal quartersR = (change % .25m);
                decimal dimes = Math.Floor(quartersR / .10m);
                decimal dimesR = (quartersR % .10m);
                decimal nickels = Math.Floor(dimesR % .05m);
                decimal nickelsR = (dimesR % .05m);
                decimal pennies = (nickelsR / .01m);

                Console.WriteLine("Total change = " + change + " paid to customer");
                if (dollars < 2 & dollars > 0)
                {
                    Console.WriteLine("Give the customer " + dollars + " dollar, ");
                }
                else
                {
                    Console.WriteLine("Give the customer " + dollars + " dollars, ");
                }

                if (quarters < 2 & quarters > 0)
                {
                    Console.WriteLine(+ quarters + " quarter.");
                }
                else {
                    Console.WriteLine(+ quarters + " quarters.");
                }

                if (dimes < 2 & dimes > 0)
                {
                    Console.WriteLine(+dimes + " dime.");
                }
                else {
                    Console.WriteLine(+dimes + " dimes.");
                }

                if (nickels < 2 & nickels > 0)
                {
                    Console.WriteLine(+nickels + " nickel.");
                }
                else {
                    Console.WriteLine(+nickels + " nickels.");
                }

                if (pennies < 2 & pennies > 0)
                {
                    Console.WriteLine("and 1 penny");
                }
                else
                {
                Console.WriteLine("and " + pennies + " pennies");
                }

                Console.ReadKey();
            }
        }
    }
}