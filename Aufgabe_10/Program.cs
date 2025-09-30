namespace Aufgabe_10_BLJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib eine positive ganze Zahl ein: ");
            int zahl = Convert.ToInt32(Console.ReadLine());

            int quersumme = BerechneQuersumme(zahl);

            Console.WriteLine($"Die Quersumme von {zahl} ist: {quersumme}");
        }

        static int BerechneQuersumme(int zahl)
        {
            int sum = 0;

            while (zahl != 0)
            {
                sum = sum + (zahl % 10);
                zahl = zahl / 10;
            }

            return sum;
        }
    }
}
