using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorog_ut
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> itinerary = new Dictionary<string, List<string>>();

            while (true)
            {
                Console.WriteLine("Görögországi Kirándulás Menetrend:");
                Console.WriteLine("1. Megjelenítés");
                Console.WriteLine("2. Hozzáadás új nap");
                Console.WriteLine("3. Hozzáadás esemény egy napra");
                Console.WriteLine("4. Kilépés és mentés");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        DisplayItinerary(itinerary);
                        break;
                    case "2":
                        AddDay(itinerary);
                        break;
                    case "3":
                        AddEvent(itinerary);
                        break;
                    case "4":
                        SaveItinerary(itinerary);
                        break;
                    default:
                        Console.WriteLine("Érvénytelen választás.");
                        break;
                }
            }
        }

        static void DisplayItinerary(Dictionary<string, List<string>> itinerary)
        {
            Console.WriteLine("Menetrend:");
            foreach (var day in itinerary)
            {
                Console.WriteLine(day.Key);
                foreach (var evt in day.Value)
                {
                    //{evt} a day.Value listában talált aktuális esemény szövegét fogja behelyettesíteni.
                    Console.WriteLine($"- {evt}");
                }
                Console.WriteLine();
            }
        }

        static void AddDay(Dictionary<string, List<string>> itinerary)
        {
            Console.Write("Adja meg az új nap nevét: ");
            string dayName = Console.ReadLine();
            itinerary[dayName] = new List<string>();
            Console.WriteLine($"'{dayName}' hozzáadva a menetrendhez.");
        }

        static void AddEvent(Dictionary<string, List<string>> itinerary)
        {
            Console.Write("Adja meg a nap nevét, ahova az eseményt hozzá szeretné adni: ");
            string dayName = Console.ReadLine();

            if (itinerary.ContainsKey(dayName))
            {
                Console.Write("Adja meg az új eseményt: ");
                string newEvent = Console.ReadLine();
                itinerary[dayName].Add(newEvent);
                Console.WriteLine($"'{newEvent}' hozzáadva a '{dayName}' napjához.");
            }
            else
            {
                Console.WriteLine("Nincs ilyen nap a menetrendben.");
            }
        }

        static void SaveItinerary(Dictionary<string, List<string>> itinerary)
        {
            Console.Write("Szeretné menteni a menetrendet egy fájlba? (Igen/Nem): ");
            string response = Console.ReadLine().ToLower();

            if (response == "igen" || response == "i")
            {
                Console.Write("Adja meg a fájl nevét: ");
                string fileName = Console.ReadLine();
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine("Görögországi Kirándulás Menetrend:");

                    foreach (var day in itinerary)
                    {
                        writer.WriteLine(day.Key);
                        foreach (var evt in day.Value)
                        {
                            writer.WriteLine($"- {evt}");
                        }
                        writer.WriteLine();
                    }
                }
                Console.WriteLine($"Menetrend mentve a '{fileName}' fájlba.");
            }
            else
            {
                Console.WriteLine("Menetrend nem lett mentve.");
            }

            Console.WriteLine("Nyomjon meg egy billentyűt a kilépéshez...");
            Console.ReadKey();

        }
    }
}
 

  


