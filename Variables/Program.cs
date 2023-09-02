using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Változók
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integer variable
            int age = 30;

            // String variable
            string name = "John Doe";

            // A floating-point number is variable
            double temperature = 25.5;

            // Boolean variable
            bool isStudent = true;

            // Char variable
            char grade = 'A';

            // An array of integers
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Output to the console
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Temperature: " + temperature);
            Console.WriteLine("Student: " + isStudent);
            Console.WriteLine("Grade: " + grade);

            // Adding and writing whole numbers
            int num1 = 10;
            int num2 = 5;
            int sum = num1 + num2;
            Console.WriteLine("Összeg: " + sum);

            // Concatenate text
            string greeting = "Helló, ";
            string target = "Világ!";
            string message = greeting + target;
            Console.WriteLine(message);


            // Addition
            int adding = 5 + 3;
            Console.WriteLine("Sum: " + adding);

            // Subtraction
            int difference = 10 - 4;
            Console.WriteLine("Difference: " + difference);
            
            // Multiplication
            int product = 6 * 7;
            Console.WriteLine("Product: " + product);
            
            // Division
            double quotient = 15.0 / 3.0;
            Console.WriteLine("Quotient: " + quotient);
            
            // Remainder calculation
            int remainder = 10 % 3;
            Console.WriteLine("Remainder: " + remainder);
            
            // Expressions
            int x = 5;
            int y = 3;
            int result1 = x + y * 2; 
            int result2 = (x + y) * 2;
            Console.WriteLine("Result1: " + result1);
            Console.WriteLine("Result2: " + result2);

            // Compound expressions
            int a = 10;
            int b = 3;
            int c = 5;
            int result3 = (a + b) * c;
            Console.WriteLine("Result3: " + result3);

            // Other operations
            int increment = 5;
            increment++;  
            increment--; 

            int negation = -10;
            Console.WriteLine("Increment: " + increment);

            //Rounding a division
            int roundedResult = 7 / 2; 
            double preciseResult = 7.0 / 2.0;
            Console.WriteLine("RoundedResult: " + roundedResult);
            Console.WriteLine("PreciseResult: " + preciseResult);

            // Exponentiation
            double square = Math.Pow(2, 2);
            Console.WriteLine("Square: " + square);
          
            // Root trait
            double squareRoot = Math.Sqrt(16);
            Console.WriteLine("SquareRoot: " + squareRoot);


            // Logic operations
            bool isTrue = true;
            bool isFalse = false;
            bool logicalAnd = isTrue && isFalse; // The result will be false
            bool logicalOr = isTrue || isFalse; //The result will be true
            bool logicalNot = !isTrue; // The result will be false

            Console.WriteLine("LogicalAnd: " + logicalAnd);
            Console.WriteLine("LogicalOr: " + logicalOr);
            Console.WriteLine("LogicalNot: " + logicalNot);

            Console.ReadKey();



        }
    }
}
