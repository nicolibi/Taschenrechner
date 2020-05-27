using System;

namespace Taschenrechner
{
    class Program
    {
        public static void Main()
        {
            //User Story "Addieren" 
            string ersteZahlalsString = HoleBenutzereingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlalsTring = HoleBenutzereingabe("Bitte gib  die zweite Zahl ein: ");
            string operation = HoleBenutzereingabe("Welche Operation möchtest du ausführen (+ oder -)? ");

            //Konvertieren in Gleitkommazahl
            //TODO: Auslagern in Funktion wenn der Code umfangreicher wird
            double ersteZahl = Convert.ToDouble(ersteZahlalsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlalsTring);

            double resultat = 0;
            switch (operation)
            {
                case "+":
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Summe ist {0}", resultat);
                    break;

                case "-":
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    Console.WriteLine("Die Differenz ist {0}", resultat);
                    break;

                case "/":
                case "*":
                    Console.WriteLine("Coming Soon");
                    break;


                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl für die Operation getroffen");
                    break;
            }



            HoleBenutzereingabe("Zum Beenden bitte Enter Taste drücken");
        }

        static string HoleBenutzereingabe(string ausgabetext)
        {
            Console.Write(ausgabetext);
            string summand = Console.ReadLine();
            return summand;
        }

        static double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;
            return summe;
        }


        static double Subtrahiere(double minunend, double subtrahent)
        {
            double differenz = minunend - subtrahent;
            return differenz;
        }
    }
}
