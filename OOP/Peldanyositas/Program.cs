using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macska
{
    class Macska
    {
        //get visszaadja az adat tag értékeit a set beállítja azt
        public string Nev { get; set; }
        public int Eletkor { get; set; }
        public bool Cirmos { get; set; }

        // Konstruktor a macska objektum létrehozásához
        public Macska(string nev, int eletkor, bool cirmos)

        {

            //Az alapvető különbség az, hogy az első példában az adattagok közvetlenül elérhetők
            //a getter és setter metódusokon keresztül, míg a második példában az adattagok privátak,
            //és a this kulcsszó használata szükséges az egyértelműsítéshez,
            //mivel a paraméterek nevei megegyezhetnek az adattagok neveivel.
            //Az this kulcsszó segít elkerülni az esetleges nevezési konfliktusokat.
            Nev = nev;
            Eletkor = eletkor;
            Cirmos = cirmos;
        }

        // Metódus a macska adatainak kiírásához
        public void KiirMacskaAdatai()
        {
            Console.WriteLine($"A macska neve: {Nev}");
            Console.WriteLine($"A macska életkora: {Eletkor} éves");
            Console.WriteLine($"A macska {(Cirmos ? "cirmos." : "nem cirmos.")}");
        }
    }
    internal class Program
    {

      
            static void Main(string[] args)
        { // Felhasználótól kérjük be a macska adatait
            Console.Write("Kérem, adja meg a macska nevét: ");
            string nev = Console.ReadLine();

            Console.Write("Kérem, adja meg a macska életkorát: ");
            int eletkor;
            if (!int.TryParse(Console.ReadLine(), out eletkor))
            {
                Console.WriteLine("Hibás életkor. Kérem, adjon meg egy érvényes életkort.");
                return;
            }

            Console.Write("A macska cirmos-e? (igen/nem): ");
            string cirmosValasz = Console.ReadLine();
            bool cirmos = cirmosValasz.ToLower() == "igen";

            // Példányosítunk egy Macska objektumot a felhasználó által megadott adatokkal
            Macska macska = new Macska(nev, eletkor, cirmos);

            // Kiírjuk a macska adatait
            macska.KiirMacskaAdatai();

            // Várakozás a kilépéshez
            Console.ReadLine();
        }
    }
    }
    

