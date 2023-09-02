using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ciklusok_for__while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For loop:
            Console.WriteLine("For loop");

            //For loops are usually used when we know in advance how many times we want to repeat an operation.
            //The for loop syntax:
            /*for (initial_value; condition; step)
            {
                // Here are the actions we repeat
            }*/

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("While loop:");

            //While:
            // A while loop in C# performs repeated actions until a given condition is true. Here is the general syntax:
            /*while (condition)
            {
                // Here are the actions we repeat
            }
            */

            int number = 1;
            while (number <= 10)
            {
                Console.WriteLine(number);
                number++;
            }
            Console.WriteLine("Do-While loop:");
            // do -while loop
            //which repeats a certain block of code until a given condition remains true.
            //The point is that the loop body executes at least once, even if the condition is initially false.
            //It then checks the condition and continues to repeat only if the condition is true.
            /*
            int a = 2;
            do
            {
                // the instructions to be executed are placed here
            }
            while (a > 0); //condition

            */
            int num;

            do
            {
                Console.Write("Please enter a positive number: ");
                num = Convert.ToInt32(Console.ReadLine());

                //Convert.ToInt32 is a method that converts the value received as a parameter into an integer.
                //The data read on the console originally comes in text format,
                //and we convert it to number format using Convert.ToInt32.

                
                if (num > 0)
                {
                    Console.WriteLine("The number you entered: " + num);
                }
                else
                {
                    Console.WriteLine("The number entered is not positive, please try again.");
                }
            }
            while (num <= 0);

            Console.WriteLine("Thanks! The program has ended.");

            Console.WriteLine("Foreach:");
            //"foreach" is an iteration loop control structure in programming
            //that is used to iterate through a collection or elements in a collection
            //( array, list, set) and perform a specified operation on each element

            /* foreach (elementType element in collection)
             {
                 // This is where you perform the operations on the element
             }*/


            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int numb in numbers)
            {
                Console.WriteLine(numb);
            }

            Console.WriteLine("Switch");
            //A "switch" statement is a control structure in programming that compares the value of a variable or
            //expression with a series of different cases.
            //When it finds the right case, it executes the block of code there.
            //The "switch" statement is useful if we want to handle several possible values ​​and
            //perform different actions based on them.

            int day = 3;
            string dayName = "";

            switch (day)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                default:
                    dayName = "Unknown day";
                    break;
            }

            Console.WriteLine($"The selected day: {dayName}");

            //Example of the "continue" statement:

            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("We skip this iteration.");
                    continue;
                }
                Console.WriteLine($"Number of iterations: {i}");
            }

            /*
            //In this example, the loop is infinite because the loop condition always remains true.
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

            while (true)
            {
                foreach (var color in colors)
                {
                    Console.ForegroundColor = color;
                    Console.Clear();
                    Console.WriteLine($"Jelenlegi szín: {color}");
                    Thread.Sleep(500); // Várakozás fél másodpercig
                }
            }*/

            Console.ReadKey();
        }
    }
}
