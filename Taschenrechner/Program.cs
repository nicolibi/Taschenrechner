using System;

namespace Taschenrechner
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Bitte gib den ersten Summanden ein:  ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            double ersterSummandZahl = Convert.ToDouble(ersterSummand);
            double zweiterSummandZahl = Convert.ToDouble(zweiterSummand);

            double summe = ersterSummandZahl + zweiterSummandZahl;

            Console.WriteLine("Die Summe ist {0}", summe);

            Console.ReadLine();
        }
    }
}
