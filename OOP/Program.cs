using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutya
{
    class Kutya
    {
        private string nev;
        private int kor;

        public Kutya(string nev, int kor)
        {
            this.nev = nev;
            this.kor = kor;
        }

        public string GetAdatok()
        {
            return $"Név: {nev}, Kor: {kor}";
        }





    }



    internal class Program
    {
        static void Main(string[] args)
        {

            Kutya k = new Kutya("Zeusz", 2);
            Console.WriteLine(k.GetAdatok());

            Console.ReadKey();


        }
    }
}
