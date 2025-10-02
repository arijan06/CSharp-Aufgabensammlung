namespace Aufgabe_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deine Eingabe:");
            string eingabe = Console.ReadLine().ToLower();

            int gesamt = 0;
            int a = 0, e = 0, i = 0, o = 0, u = 0;

            foreach (char c in eingabe)
            {
                switch (c)
                {
                    case 'a': a++; gesamt++; break;
                    case 'e': e++; gesamt++; break;
                    case 'i': i++; gesamt++; break;
                    case 'o': o++; gesamt++; break;
                    case 'u': u++; gesamt++; break;
                }
            }

            Console.WriteLine($"\nDein Text hat total {gesamt} Vokale.");
            if (a > 0) Console.WriteLine($"Der Buchstabe 'a' kommt {a} mal vor.");
            if (e > 0) Console.WriteLine($"Der Buchstabe 'e' kommt {e} mal vor.");
            if (i > 0) Console.WriteLine($"Der Buchstabe 'i' kommt {i} mal vor.");
            if (o > 0) Console.WriteLine($"Der Buchstabe 'o' kommt {o} mal vor.");
            if (u > 0) Console.WriteLine($"Der Buchstabe 'u' kommt {u} mal vor.");
        }
    }
}
