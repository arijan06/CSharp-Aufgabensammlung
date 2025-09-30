namespace Aufgabe_5_BLJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Kilometer möchtest du rennen?");
            double km = Convert.ToDouble(Console.ReadLine());

            // Überprüfung: mehr als 42 km?
            if (km > 42)
            {
                Console.WriteLine("Das schaffst du nicht!");
                return;
            }

            // Umrechnung in Runden (1 Runde = 400 m)
            double n = (km * 1000) / 400;

            Console.WriteLine($"Das sind {n} Runden. Bereit für den Lauf? (j/n)");
            string bereit = Console.ReadLine();

            if (bereit.ToLower() != "j")
            {
                Console.WriteLine("Schade, vielleicht ein andermal!");
                return;
            }

            // Lauf starten
            int i = 1;
            while (i <= n)
            {
                Console.WriteLine($"Du läufst Runde {i}");
                i++;
            }

            Console.WriteLine("Du hast es geschafft!");
        }
    }
}
