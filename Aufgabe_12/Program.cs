using System;
using System.Linq; 

namespace Aufgabe_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib mir so viele Zahlen wie du willst (mit Leerzeichen getrennt):");
            string eingabe = Console.ReadLine();

            int[] zahlen = eingabe.Split(' ').Select(int.Parse).ToArray();

            int[] result = SumUp(zahlen);

            Console.WriteLine("Ergebnis:");
            Console.WriteLine(string.Join(", ", result));
        }

        static int[] SumUp(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                result[i] = sum;
            }

            return result;
        }
    }
}