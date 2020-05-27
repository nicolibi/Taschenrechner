using System;

namespace Taschenrechner
{
    class Program
    {
        public static void Main()
        {
            //User Storys für Berechnungsoperationen, Abfrage der Oparatoren und Operation
            string ersteZahlalsString = HoleBenutzereingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlalsTring = HoleBenutzereingabe("Bitte gib  die zweite Zahl ein: ");

            string operation = HoleBenutzereingabe("Welche Operation möchtest du ausführen (+ ,-, /, *)? ");

            //Konvertieren in Gleitkommazahl
            //TODO: Auslagern in Funktion wenn der Code umfangreicher wird
            double ersteZahl = Convert.ToDouble(ersteZahlalsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlalsTring);

            double resultat = Berechne(ersteZahl, zweiteZahl, operation);
            GibResultatAus(resultat);

            HoleBenutzereingabe("Zum Beenden bitte Enter Taste drücken");
        }

        static string HoleBenutzereingabe(string ausgabetext)
        {
            Console.Write(ausgabetext);
            string summand = Console.ReadLine();
            return summand;
        }

        static double Berechne(double ersteZahl, double zweiteZahl, string operation)
        {
            double resultat = 0;
            switch (operation)
            {
                case "+":
                    resultat = Addiere(ersteZahl, zweiteZahl);
                    break;

                case "-":
                    resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;

                case "/":
                    resultat = Dividiere(ersteZahl, zweiteZahl);
                    break;


                case "*":
                    resultat = Multipliziere(ersteZahl, zweiteZahl);
                    break;


                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl für die Operation getroffen");
                    break;
            }

            return resultat;

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

        static double Multipliziere(double multiplikator, double multiplikant)
        {
            double produkt = multiplikator * multiplikant;
            return produkt;
        }

        static double Dividiere(double dividend, double divisor)
        {

            double quotient = dividend / divisor;
            return quotient;
        }

        static void GibResultatAus(double resultat)
        {
            Console.WriteLine("Das Resultat hat den Wert {0}", resultat);
        }


    }



}
