using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //If - else
            int number = 7;

            if (number % 2 == 0)
            {
                // If the number is divisible by two (without a remainder), it is even.
                Console.WriteLine(number + " even number.");
            }
            else
            {
                // If the number is not divisible by two without a remainder, then it is odd.
                Console.WriteLine(number + " odd number.");
            }


            Console.WriteLine("You can choose pizza sizes: S, M, L");
            Console.Write("Please enter the size of the pizza: ");
            string size = Console.ReadLine(); 

            if (size == "S" || size == "M" || size == "L" || size == "s" || size == "m" || size == "l" )
            {
                Console.WriteLine("What toppings would you like the pizza with? (cheese, salami, mushrooms)");
                string toppings = Console.ReadLine();

                Console.WriteLine("Ordered pizza:");
                Console.WriteLine($"Size: {size}");
                Console.WriteLine($"Toppings: {toppings}");
            }
            else
            {
                Console.WriteLine("Invalid size. Please choose from the available sizes: S, M, L");
            }
            Console.ReadKey();
            
            }
        }
    }

