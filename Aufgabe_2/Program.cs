using System;

namespace Aufgabe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnung der Anzahl Sekunden eines Monats");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Wie viele Tage hat der Monat, für den Sie die Sekundenzahl berechnen wollen?");
            int Tage;
            string Eingabe = Console.ReadLine();

            if (int.TryParse(Eingabe, out Tage))
            {
                if (Tage > 27 == true && Tage < 32 == true)
                {
                        Console.WriteLine("Ein Monat mit " + Tage + " Tagen hat " + (Tage * 86400) + " Sekunden.");
                }

                else
                {
                        Console.WriteLine("Ein Monat mit " + Tage + " Tagen gibt es nicht.");
                }
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Ganzzahl erwartet.");
            }
        }
    }
}
