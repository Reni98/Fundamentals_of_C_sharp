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
            // Egész szám változó
            int age = 30;

            // Szöveg változó (string)
            string name = "John Doe";

            // Lebegőpontos szám változó
            double temperature = 25.5;

            // Logikai változó (bool)
            bool isStudent = true;

            // Karakter változó (char)
            char grade = 'A';

            // Egész szám tömb
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Kiírás a konzolra
            Console.WriteLine("Név: " + name);
            Console.WriteLine("Kor: " + age);
            Console.WriteLine("Hőmérséklet: " + temperature);
            Console.WriteLine("Diák: " + isStudent);
            Console.WriteLine("Érdemjegy: " + grade);

            // Egész számok összeadása és kiíratása
            int num1 = 10;
            int num2 = 5;
            int sum = num1 + num2;
            Console.WriteLine("Összeg: " + sum);

            // Szöveg összefűzése
            string greeting = "Helló, ";
            string target = "Világ!";
            string message = greeting + target;
            Console.WriteLine(message);


            // Összeadás
            int adding = 5 + 3;
            Console.WriteLine("Sum: " + adding);

            // Kivonás
            int difference = 10 - 4;
            Console.WriteLine("Difference: " + difference);
            // Szorzás
            int product = 6 * 7;
            Console.WriteLine("Product: " + product);
            // Osztás
            double quotient = 15.0 / 3.0;
            Console.WriteLine("Quotient: " + quotient);
            // Maradék számítása (modulo)
            int remainder = 10 % 3;
            Console.WriteLine("Remainder: " + remainder);
            // Kifejezések
            int x = 5;
            int y = 3;
            int result1 = x + y * 2; 
            int result2 = (x + y) * 2;
            Console.WriteLine("Result1: " + result1);
            Console.WriteLine("Result2: " + result2);

            // Összetett kifejezések
            int a = 10;
            int b = 3;
            int c = 5;
            int result3 = (a + b) * c;
            Console.WriteLine("Result3: " + result3);

            // Egyéb műveletek
            int increment = 5;
            increment++;  
            increment--; 

            int negation = -10;
            Console.WriteLine("Increment: " + increment);

            // Osztás kerekítése
            int roundedResult = 7 / 2; 
            double preciseResult = 7.0 / 2.0;
            Console.WriteLine("RoundedResult: " + roundedResult);
            Console.WriteLine("PreciseResult: " + preciseResult);

            // Hatványozás
            double square = Math.Pow(2, 2);
            Console.WriteLine("Square: " + square);
          
            // Gyökvonás
            double squareRoot = Math.Sqrt(16);
            Console.WriteLine("SquareRoot: " + squareRoot);


            // Logikai műveletek
            bool isTrue = true;
            bool isFalse = false;
            bool logicalAnd = isTrue && isFalse; // Az eredmény false lesz
            bool logicalOr = isTrue || isFalse; // Az eredmény true lesz
            bool logicalNot = !isTrue; // Az eredmény false lesz

            Console.WriteLine("LogicalAnd: " + logicalAnd);
            Console.WriteLine("LogicalOr: " + logicalOr);
            Console.WriteLine("LogicalNot: " + logicalNot);

            Console.ReadKey();



        }
    }
}
