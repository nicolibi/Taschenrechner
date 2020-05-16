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

            double summe = Addiere(ersterSummandZahl, zweiterSummandZahl);

            Console.WriteLine("Die Summe ist {0}", summe);
            WarteAufBenutzerEingabe();
        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;
            return summe;
        }
        static void WarteAufBenutzerEingabe()
        {
            Console.WriteLine("Zum Beenden bitte Enter Taste drücken");
            Console.ReadLine();
        }
    }
}
