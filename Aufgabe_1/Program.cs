namespace Aufgabe_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zahl1;
            int zahl2;

            Console.WriteLine("Hallo, gib eine Zahl zum Addieren ein:");
            string eingabe1 = Console.ReadLine();
            zahl1 = Convert.ToInt32(eingabe1);

            Console.WriteLine("Und gib jetzt eine zweite Zahl ein:");
            string eingabe2 = Console.ReadLine();
            zahl2 = Convert.ToInt32(eingabe2);


            int summe = zahl1 + zahl2;

            Console.WriteLine("Das ergibt: " + summe);
            Console.WriteLine("Tippe eine Taste um das Fenster zu schliessen");
        }

    }
}
