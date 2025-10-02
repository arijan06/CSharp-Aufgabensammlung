using System;

namespace Aufgabe_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib ein Geburtsdatum an: ");
            Console.Write("Deine Eingabe (TT.MM.JJJJ): ");
            string eingabe = Console.ReadLine();
            DateTime geburtsdatum;

            if (DateTime.TryParse(eingabe, out geburtsdatum))
            {
                DateTime heute = DateTime.Today;

                int jahre = heute.Year - geburtsdatum.Year;
                if (geburtsdatum > heute.AddYears(-jahre)) jahre--;

                int monate = jahre * 12 + heute.Month - geburtsdatum.Month;
                if (geburtsdatum.Day > heute.Day) monate--;

                int tage = (heute - geburtsdatum).Days;

                int wochen = tage / 7;

                Console.WriteLine($"Du bist {jahre} Jahre alt.");
                Console.WriteLine($"Das sind ungefähr {monate} Monate.");
                Console.WriteLine($"Oder {wochen} Wochen.");
                Console.WriteLine($"Oder {tage} Tage.");
            }
            else
            {
                Console.WriteLine("Ungültiges Datum. Bitte im Format TT.MM.JJJJ eingeben.");
            }

            Console.WriteLine("Drücke eine Taste, um zu beenden...");
            Console.ReadKey();
        }
    }
}
