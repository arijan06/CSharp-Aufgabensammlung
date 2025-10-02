namespace Aufgabe_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prüfen Sie, os es sich um einen Schaltjahr handelt.");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Geben Sie ein Jahr ein (Drücke q zum Verlassen): ");
            string eingabe = Console.ReadLine();


            while (true)
            {
                if (int.TryParse(eingabe, out int jahr))
                {
                    if ((jahr % 4 == 0 && jahr % 100 != 0) || (jahr % 400 == 0))
                    {
                        Console.WriteLine($"{jahr} ist ein Schaltjahr.");
                    }
                    else
                    {
                        Console.WriteLine($"{jahr} ist kein Schaltjahr.");
                    }
                }

                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Jahreszahl ein.");
                }
                    Console.Write("\nGeben Sie ein Jahr ein (Drücke q zum Verlassen): ");
                    eingabe = Console.ReadLine();
            }
        }
    }
}
