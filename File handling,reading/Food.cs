using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fájbeolvasás
{
    internal class Food
    {
        public int week;
        public string meal;
        public string name;
        public string price;
        public string pieces;

        public Food(string week, string meal, string name, string price, string pieces)
        {
            this.week = int.Parse(week);
            this.meal = meal;
            this.name = name;
            this.price = price;
            this.pieces = pieces;
        }
    }
}
