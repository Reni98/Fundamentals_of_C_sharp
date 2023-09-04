using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fájlbaírás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The name of the file we want to write to
            string fileName = "moviein2023.txt";

           
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            try
            {
               
                using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8))
                {
                    // Write text to the file
                    writer.WriteLine("Movies coming out in 2023.");
                    writer.WriteLine(" The Red Door");
                    writer.WriteLine("Barbie");
                    writer.WriteLine("Oppenheimer");
                    writer.WriteLine("Blue Beetle");
                    writer.WriteLine("The Equalizer 3");
                   

                    // Writing variables to file
                    int number = 42;
                    string day = "monday";
                    writer.WriteLine("Number: " + number);
                    writer.WriteLine("Day: " + day);
                }

                Console.WriteLine("Data successfully written to file");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while writing the file: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
