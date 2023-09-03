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
            // Create an array
            int[] numbers = new int[5]; // Create an integer array with 5 elements

            // Storing data in the array
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            //Reading data from the array
            Console.WriteLine("The fifth Element: " + numbers[4]); // 50

            // Query the size of an array
            int size = numbers.Length;
            Console.WriteLine("Array size: " + size); // 5

            //Read all elements using a loop
            Console.WriteLine("Az összes elem:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Initialize an array immediately with values
            string[] names = { "Alice", "Bob", "Charlie" };

            // Read all elements using a foreach loop
            Console.WriteLine("Names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            // Create an initial array
            int[] originalArry = new int[3] { 10, 20, 30 };

            // Create a new array with a larger size
            int newSize = originalArry.Length + 1;
            int[] newArray = new int[newSize];

            //Copy the original elements to the new array
            for (int i = 0; i < originalArry.Length; i++)
            {
                newArray[i] = originalArry[i];
            }

            // Add a new element to the new array
            newArray[newSize - 1] = 40;

            // Replace the original array with the new array
            originalArry = newArray;

            // Listing the array expanded with new elements
            Console.WriteLine("The contents of the new array:");
            foreach (int number in originalArry)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
