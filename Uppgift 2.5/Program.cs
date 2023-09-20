using System;
namespace Uppgift2_5
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Skriv en multiplikation.");
            string hela = Console.ReadLine();
            int multTecken = hela.IndexOf("*");

            double tal1 = double.Parse(hela[..multTecken]);
            double tal2 = double.Parse(hela[(multTecken + 1)..]);

            double summa = tal1 * tal2;

            Console.WriteLine(tal1 + " * " + tal2 + " = " + summa);
            Console.ReadKey();
        }
    }
}