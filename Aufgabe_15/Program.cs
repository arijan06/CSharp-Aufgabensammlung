using System;

namespace Aufgabe_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes? ");
            int breite = int.Parse(Console.ReadLine());

            Console.Write("Höhe des Stammes? ");
            int höhe = int.Parse(Console.ReadLine());

            Console.Write("Höhe der Krone? ");
            int kronenhöhe = int.Parse(Console.ReadLine());

            int gesamtbreite = kronenhöhe * 2 + 1;
            int gesamthöhe = kronenhöhe + höhe;

            char[,] baum = new char[gesamthöhe, gesamtbreite];

            for (int i = 0; i < gesamthöhe; i++)
                for (int j = 0; j < gesamtbreite; j++)
                    baum[i, j] = ' ';

            int mitte = gesamtbreite / 2;

            for (int i = 0; i < kronenhöhe; i++)
            {
                for (int j = mitte - i; j <= mitte + i; j++)
                {
                    if (j >= 0 && j < gesamtbreite)
                        baum[i, j] = '*';
                }
            }

            int stammStart = mitte - (breite / 2);
            for (int i = 0; i < höhe; i++)
            {
                for (int j = 0; j < breite; j++)
                {
                    int x = stammStart + j;
                    int y = kronenhöhe + i;
                    if (x >= 0 && x < gesamtbreite)
                        baum[y, x] = '#';
                }
            }

            for (int i = 0; i < gesamthöhe; i++)
            {
                for (int j = 0; j < gesamtbreite; j++)
                {
                    Console.Write(baum[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nDrücke eine Taste, um zu beenden...");
            Console.ReadKey();
        }
    }
}
