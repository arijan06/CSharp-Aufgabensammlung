namespace Aufgabe_8_BLJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] verboteneWoerter = { "Hund", "Bastard", "Wixer", "Hurensohn", "Fick dich" };

            Console.WriteLine("Bitte gib deinen Kommentar ein:");
            string kommentar = Console.ReadLine() ?? string.Empty;

            bool enthaeltVerboten = false;

            foreach (string wort in verboteneWoerter)
            {
                if (kommentar.ToLower().Contains(wort.ToLower()))
                {
                    enthaeltVerboten = true;
                    break;
                }
            }

            if (enthaeltVerboten)
            {
                Console.WriteLine("Dein Kommentar enthält verbotene Wörter und kann nicht akzeptiert werden!");
            }
            else
            {
                Console.WriteLine("Dein Kommentar ist in Ordnung. Vielen Dank!");
            }
        }
    }
}
