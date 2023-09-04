using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ciklusok_for__while_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For loop:
            Console.WriteLine("For loop");

            //A for ciklusokat általában akkor használjuk, amikor előre tudjuk, hogy hány alkalommal szeretnénk megismételni egy műveletet.
            //A for ciklus szintaxisa: 
            /*for (kezdeti_érték; feltétel;lépés)
            {
                // Here are the actions we repeat
            }*/

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("While loop:");

            //While:
            //A C# nyelvben a while ciklus ismételt műveleteket hajt végre addig, amíg egy adott feltétel igaz.
            /*while (feltétel)
            {
                // Itt vannak az ismételt cselekvések
            }
            */

            int number = 1;
            while (number <= 10)
            {
                Console.WriteLine(number);
                number++;
            }
            Console.WriteLine("Do-While loop:");
            // do -while loop
            //amely egy bizonyos kódblokkot ismétel, amíg egy adott feltétel igaz marad."
            //A lényeg az, hogy a ciklus törzse legalább egyszer végrehajtódik, akkor is, ha a feltétel kezdetben hamis
            //Ezután ellenőrzi a feltételt, és csak akkor folytatja az ismétlést, ha a feltétel igaz.
            /*
            int a = 2;
            do
            {
                // the instructions to be executed are placed here
            }
            while (a > 0); //condition

            */
            int num;

            do
            {
                Console.Write("Please enter a positive number: ");
                num = Convert.ToInt32(Console.ReadLine());

                //A Convert.ToInt32 egy olyan metódus, 
                //amely átalakítja a paraméterként kapott értéket egész számmá.
                //A konzolon beolvasott adat eredetileg szöveges formátumban érkezik,
                //és a Convert.ToInt32 segítségével alakítjuk át szám formátumra.
                

                
                if (num > 0)
                {
                    Console.WriteLine("The number you entered: " + num);
                }
                else
                {
                    Console.WriteLine("The number entered is not positive, please try again.");
                }
            }
            while (num <= 0);

            Console.WriteLine("Thanks! The program has ended.");

            Console.WriteLine("Foreach:");
            //A 'foreach' egy iterációs ciklusvezérlő struktúra a programozásban, 
            //amit arra használnak,ogy végigiteráljon egy gyűjteményen vagy a gyűjtemény elemein
            //(tömb, lista, halmaz),és végrehajtson egy meghatározott műveletet minden elemen.
            

            /* foreach (elementType element in collection)
             {
                 // Itt hajtod végre a műveleteket az elemeken
             }*/


            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int numb in numbers)
            {
                Console.WriteLine(numb);
            }

            Console.WriteLine("Switch");
            //A 'switch' utasítás egy vezérlési struktúra a programozásban, amely összehasonlítja 
            //egy változó vagy kifejezés értékét különböző esetekkel.
            //Amikor megtalálja a megfelelő esetet, végrehajtja a kódblokkot ott. 
            //A 'switch' utasítás hasznos, ha több lehetséges értéket szeretnénk kezelni, 
            //és különböző műveleteket szeretnénk végrehajtani az alapján.

            int day = 3;
            string dayName = "";

            switch (day)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                default:
                    dayName = "Unknown day";
                    break;
            }

            Console.WriteLine($"The selected day: {dayName}");

            //Example of the "continue" statement:

            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine("We skip this iteration.");
                    continue;
                }
                Console.WriteLine($"Number of iterations: {i}");
            }

            /*
            //Ebben a példában a ciklus végtelen, mert a ciklus feltétel mindig igaz marad.
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            
            //A konzol szöveg színét a Console.ForegroundColor beállításával változtatja meg, 
            //majd a jelenlegi színt kiírja a konzolra. 
            //A folyamat végtelenül ismétlődik, és a színek közötti átmenetet mutatja be.
            while (true)
            {
                foreach (var color in colors)
                {
                    Console.ForegroundColor = color;
                    Console.Clear();
                    Console.WriteLine($"Jelenlegi szín: {color}");
                    Thread.Sleep(500); // Várakozás fél másodpercig
                }
            }*/

            Console.ReadKey();
        }
    }
}
