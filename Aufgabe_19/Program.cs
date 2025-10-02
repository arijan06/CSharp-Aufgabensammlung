using System;

namespace Aufgabe_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                while (true) 
                {
                    Console.WriteLine("Gib eine Rechnung ein:");
                    string eingabe = Console.ReadLine();

                    eingabe = eingabe.Replace(" ", "");

                    if (string.IsNullOrWhiteSpace(eingabe))
                    {
                        Console.WriteLine("Bitte etwas eingeben!");
                        continue;
                    }

                    char operatorSymbol = '\0';
                    int operatorIndex = -1;

                    foreach (char op in new[] { '+', '-', '*', '/' })
                    {
                        operatorIndex = eingabe.IndexOf(op);
                        if (operatorIndex > 0) 
                        {
                            operatorSymbol = op;
                            break;
                        }
                    }

                    if (operatorSymbol == '\0')
                    {
                        Console.WriteLine("Kein gültiger Operator gefunden. Bitte +, -, * oder / verwenden.");
                        continue;
                    }

                    string teil1 = eingabe.Substring(0, operatorIndex);
                    string teil2 = eingabe.Substring(operatorIndex + 1);

                    if (!double.TryParse(teil1, out double zahl1) || !double.TryParse(teil2, out double zahl2))
                    {
                        Console.WriteLine("Ungültige Zahlen. Bitte gültige Zahlen eingeben.");
                        continue;
                    }

                    double ergebnis;
                    switch (operatorSymbol)
                    {
                        case '+':
                            ergebnis = zahl1 + zahl2;
                            break;
                        case '-':
                            ergebnis = zahl1 - zahl2;
                            break;
                        case '*':
                            ergebnis = zahl1 * zahl2;
                            break;
                        case '/':
                            if (zahl2 == 0)
                            {
                                Console.WriteLine("Fehler: Division durch Null ist nicht erlaubt.");
                                continue;
                            }
                            ergebnis = zahl1 / zahl2;
                            break;
                        default:
                            Console.WriteLine("Ungültiger Operator. Bitte +, -, * oder / verwenden.");
                            continue;
                    }

                    Console.WriteLine($"Ergebnis: {ergebnis}");
                    break; 
                }

                Console.Write("Willst du noch eine Rechnung machen? (j/n): ");
                string antwort = Console.ReadLine().Trim().ToLower();

                if (antwort != "j")
                {
                    Console.WriteLine("Programm beendet. Auf Wiedersehen!");
                    break; 
                }

                Console.Clear();
            }
        }
    }
}
