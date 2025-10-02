namespace Aufgabe_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie lang soll die Linie sein?");
            Console.Write("Deine Eingabe:");
            int länge = int.Parse(Console.ReadLine());

            for (int i = 0; i < länge; i++)
            {
                for (int j = 0; j < länge; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
