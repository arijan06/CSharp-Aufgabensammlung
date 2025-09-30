namespace Aufgabe_9_BLJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib eine Zahl ein:");

            int zahl = Convert.ToInt32(Console.ReadLine());
            string bin = Convert.ToString(zahl, 2);
            Console.WriteLine("Die binäre Darstellung von " + zahl + " ist: " + bin);

        }
    }
}
