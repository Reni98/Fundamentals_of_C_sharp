using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informatikai_Leltar
{
    internal class Program
    {
        static List<InformatikaiTermek> leltar = new List<InformatikaiTermek>();
        static void Main(string[] args)
        {
            Console.WriteLine("Informatikai Termék Leltár Program");

            while (true)
            {
                Console.WriteLine("1. Új termék hozzáadása");
                Console.WriteLine("2. Termékek listázása");
                Console.WriteLine("3. Termék szerkesztése");
                Console.WriteLine("4. Termék törlése");
                Console.WriteLine("5. Keresés");
      

                string valasztas = Console.ReadLine();

                switch (valasztas)
                {
                    case "1":
                        AddNewProduct();
                        break;
                    case "2":
                        ListProducts();
                        break;
                    case "3":
                        EditProduct();
                        break;
                    case "4":
                        DeleteProduct();
                        break;
                    case "5":
                        SearchProduct();
                        break;
                    default:
                        Console.WriteLine("Érvénytelen választás.");
                        break;
                }
            }

        }

        static void AddNewProduct()
        {
            Console.WriteLine("Termék neve:");
            string nev = Console.ReadLine();
            Console.WriteLine("Termék típusa:");
            string tipus = Console.ReadLine();
            Console.WriteLine("Termék ára:");
            double ar;
            if (double.TryParse(Console.ReadLine(), out ar))
            {
                InformatikaiTermek ujTermek = new InformatikaiTermek(nev, tipus, ar);
                leltar.Add(ujTermek);
                Console.WriteLine("Termék hozzáadva a leltárhoz.");
            }
            else
            {
                Console.WriteLine("Hibás ár formátum.");
            }
        }

        static void ListProducts()
        {
            Console.WriteLine("Leltár:");
            foreach (var termek in leltar)
            {
                Console.WriteLine($"{termek.Nev} ({termek.Tipus}) - {termek.Ar} Ft");
            }
        }

        static void EditProduct()
        {
            Console.WriteLine("Adja meg a termék nevét, amit szerkeszteni szeretne:");
            string nev = Console.ReadLine();
            InformatikaiTermek termek = leltar.FirstOrDefault(t => t.Nev.Equals(nev, StringComparison.OrdinalIgnoreCase));

            if (termek != null)
            {
                Console.WriteLine("Új termék neve:");
                termek.Nev = Console.ReadLine();
                Console.WriteLine("Új termék típusa:");
                termek.Tipus = Console.ReadLine();
                Console.WriteLine("Új termék ára:");
                double ar;
                if (double.TryParse(Console.ReadLine(), out ar))
                {
                    termek.Ar = ar;
                    Console.WriteLine("Termék sikeresen szerkesztve.");
                }
                else
                {
                    Console.WriteLine("Hibás ár formátum.");
                }
            }
            else
            {
                Console.WriteLine("Termék nem található.");
            }
        }

        static void DeleteProduct()
        {
            Console.WriteLine("Adja meg a termék nevét, amit törölni szeretne:");
            string nev = Console.ReadLine();
            InformatikaiTermek termek = leltar.FirstOrDefault(t => t.Nev.Equals(nev, StringComparison.OrdinalIgnoreCase));

            if (termek != null)
            {
                leltar.Remove(termek);
                Console.WriteLine("Termék törölve.");
            }
            else
            {
                Console.WriteLine("Termék nem található.");
            }
        }
        static void SearchProduct()
        {
            Console.WriteLine("Adja meg a keresett termék nevét vagy típusát:");
            string kereses = Console.ReadLine().ToLower();

            var talalatok = leltar.Where(t => t.Nev.ToLower().Contains(kereses) || t.Tipus.ToLower().Contains(kereses));

            if (talalatok.Any())
            {
                Console.WriteLine("Keresési találatok:");
                foreach (var termek in talalatok)
                {
                    Console.WriteLine($"{termek.Nev} ({termek.Tipus}) - {termek.Ar} Ft");
                }
            }
            else
            {
                Console.WriteLine("Nincs találat.");
            }
        }
    }
}
