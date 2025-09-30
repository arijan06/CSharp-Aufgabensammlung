namespace Aufgabe_4_BLJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein.\n Deine Zahl:");
            //int zahl = Convert.ToInt32(Console.ReadLine());

            //if (zahl == 1)
            //{
            //    Console.WriteLine("Januar");
            //}
            //else if (zahl == 2)
            //{
            //    Console.WriteLine("Februar");
            //}
            //else if (zahl == 3)
            //{
            //    Console.WriteLine("März");
            //}
            //else if (zahl == 4)
            //{
            //    Console.WriteLine("April");
            //}
            //else if (zahl == 5)
            //{
            //    Console.WriteLine("Mai");
            //}
            //else if (zahl == 6)
            //{
            //    Console.WriteLine("Juni");
            //}
            //else if (zahl == 7)
            //{
            //    Console.WriteLine("Juli");
            //}
            //else if (zahl == 8)
            //{
            //    Console.WriteLine("August");
            //}
            //else if (zahl == 9)
            //{
            //    Console.WriteLine("September");
            //}
            //else if (zahl == 10)
            //{
            //    Console.WriteLine("Oktober");
            //}
            //else if (zahl == 11)
            //{
            //    Console.WriteLine("November");
            //}
            //else if (zahl == 12)
            //{
            //    Console.WriteLine("Dezember");
            //}
            //else
            //{
            //    Console.WriteLine("Eingabefehler. Bitte geben Sie eine Ganzzahl zwischen 1 und 12 ein.");
            //}

            //******************************************************************************************************

            int monat;
            string eingabe = Console.ReadLine();

            if (int.TryParse(eingabe, out monat) && monat>= 1 && monat <= 12)
            {
                string[] monate = {"Januar", "Februar", "März", "April", "Mai", "Juni", "Juli", "August", "September", "Oktober", "November", "Dezember"};

                Console.WriteLine(monate[monat - 1]);
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine Ganzzahl zwischen 1 und 12 ein.");
            }
        }
    }
}