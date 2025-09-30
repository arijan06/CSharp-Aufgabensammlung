using System;

namespace Aufgabe_3_BLJ
{
    class Program
    {
        static void Main()
        {
            Console.Write("Bitte gib eine Zahl zwischen 1 und 10 ein: ");
            int startzahl = int.Parse(Console.ReadLine());

            if (startzahl < 1 || startzahl > 10)
            {
                Console.WriteLine("Die Zahl muss zwischen 1 und 10 liegen!");
            }
            else
            {
                int i = startzahl;
                while (i <= 10)
                {
                    Console.WriteLine(i);
                    i = i + 1;
                }
            }

            Console.WriteLine("Drücke eine beliebige taste zum beenden");
        }
    }
}
