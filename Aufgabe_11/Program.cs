namespace Aufgabe_11_BLJ
{
    internal class Program
    {
        static int Quersumme(int zahl)
        {
            int summe = 0;
            while (zahl > 0)
            {
                summe += zahl % 10;
                zahl /= 10;
            }
            return summe;
        }

        static void Main()
        {
            Console.Write("Zahl 1: ");
            int zahl1 = int.Parse(Console.ReadLine());

            Console.Write("Zahl 2: ");
            int zahl2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("Zahl | Quersumme | Zahl / Quersumme");
            Console.WriteLine("---------------------------------");

            for (int zahl = zahl1; zahl <= zahl2; zahl++)
            {
                int qs = Quersumme(zahl);

                if (zahl % qs == 0)
                {
                    int division = zahl / qs;
                    Console.WriteLine($"{zahl,4} | {qs,9} | {division,15}");
                }

            }
        }
    }
}
