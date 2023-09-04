using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // A lista egy dinamikus méretű adatszerkezet, míg a tömbnek rögzített mérete van.
            // Ez lehetővé teszi, hogy dinamikusan hozzáadhassunk és eltávolíthassunk elemeket anélkül, hogy előre meghatároznánk a méretüket
            // Lista létrehozása
            List<int> numbers = new List<int>();

            // Elemek hozzáadása a listához
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

           //Első elem kiírása
            Console.WriteLine("The first element: " + numbers[0]); // 10

            //Lista méretének a lekérdezése
            int size = numbers.Count;
            Console.WriteLine("The size of the list: " + size); // 3

            // Az összes elem olvasása egy ciklus segítségével
            Console.WriteLine("All element:");
            for (int i = 0; i <size; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            //Elemek eltávolítása a listából
            numbers.Remove(20); // 20 remove

            // Az összes elem újbóli olvasása
            Console.WriteLine("All elements after removing 20:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
