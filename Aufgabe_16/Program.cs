namespace Aufgabe_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eine Zahl von 1 bis 100");
            Random rnd = new Random();
            int zahl = rnd.Next(1, 101);
            int versuche = 0;
            int eingabe = 0;
            while (eingabe != zahl)
            {
                Console.Write("Dein Tipp: ");
                eingabe = int.Parse(Console.ReadLine());
                versuche++;
                if (eingabe < zahl)
                {
                    Console.WriteLine("Zu niedrig!");
                }
                else if (eingabe > zahl)
                {
                    Console.WriteLine("Zu hoch!");
                }
                else
                {
                    Console.WriteLine($"Richtig! Du hast {versuche} Versuche gebraucht.");
                }
            }
            Console.WriteLine("Drücke eine Taste, um zu beenden...");
        }
    }
}
