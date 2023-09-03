using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fájbeolvasás
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Reading:
            List<Food> food_list = new List<Food>();
            string[] lines = File.ReadAllLines("menu.txt");
            foreach (var item in lines)
            {
                string[] values = item.Split(';');
                Food food_object = new Food(values[0], values[1], values[2], values[3], values[4]);
                food_list.Add(food_object);
            }

            foreach (var item in food_list)
            {
                Console.WriteLine($"{item.week};{item.meal};{item.name};{item.price};{item.pieces}");

            }
            Console.ReadKey();
        }
    }
}
