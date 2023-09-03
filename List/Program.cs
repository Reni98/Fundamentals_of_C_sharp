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

            // The list is a data structure with dynamic size, while the array has a fixed size.
            // It allows you to dynamically add and remove elements without having to define their size in advance.
            // Create a list
            List<int> numbers = new List<int>();

            // Elemek hozzáadása a listához
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            // Add elements to the list
            Console.WriteLine("The first element: " + numbers[0]); // 10

            // Query the size of a list
            int size = numbers.Count;
            Console.WriteLine("The size of the list: " + size); // 3

            // Read all elements using a loop
            Console.WriteLine("All element:");
            for (int i = 0; i <size; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Remove elements from the list
            numbers.Remove(20); // 20 remove

            // Read all elements again
            Console.WriteLine("All elements after removing 20:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
