using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tömb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tömb létrehozása
            int[] numbers = new int[5]; // Create an integer array with 5 elements

            //Adatok tárolása a tömbben
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            //Adatok olvasása a tömbbő
            Console.WriteLine("The fifth Element: " + numbers[4]); // 50

            //A tömb méretének lekérdezése
            int size = numbers.Length;
            Console.WriteLine("Array size: " + size); // 5

            //Az összes elem olvasása ciklus segítségével
            Console.WriteLine("All elements:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Tömb azonnali inicializálása értékekkel
            string[] names = { "Alice", "Bob", "Charlie" };

            //"Az összes elem olvasása egy foreach ciklus segítségével
            Console.WriteLine("Names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            //Egy kezdeti tömb létrehozása
            int[] originalArry = new int[3] { 10, 20, 30 };

            // Egy új tömb létrehozása nagyobb mérettel
            int newSize = originalArry.Length + 1;
            int[] newArray = new int[newSize];

            //Az eredeti elemek másolása az új tömbbe
            for (int i = 0; i < originalArry.Length; i++)
            {
                newArray[i] = originalArry[i];
            }

            //Egy új elem hozzáadása az új tömbhöz
            newArray[newSize - 1] = 40;

            //Az eredeti tömb cseréje az új tömbbe
            originalArry = newArray;

            // A tömb felsorolása az új elemekkel kibővítve
            Console.WriteLine("The contents of the new array:");
            foreach (int number in originalArry)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
