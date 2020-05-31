using System;

namespace Taschenrechner
{
    public class RechnerModel
    {
        public double Resultat { get; private set; }

        public string Operation { get; set; }
        public double ErsteZahl { get; set; }
        public double ZweiteZahl { get; set; }
        public bool ZahlGueltig = false;


        public RechnerModel()
        {
            Resultat = 0;
            Operation = "unbekannt";
        }

        public void Berechne()
        {
            this.Operation = Operation;

            switch (Operation)
            {
                case "+":
                    Resultat = Addiere(ErsteZahl, ZweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahiere(ErsteZahl, ZweiteZahl);
                    break;

                case "/":
                    Resultat = Dividiere(ErsteZahl, ZweiteZahl);
                    break;


                case "*":
                    Resultat = Multipliziere(ErsteZahl, ZweiteZahl);
                    break;


                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl für die Operation getroffen");
                    break;
            }

        }

        public void PruefeWertGueltig(double zahl, int abgefragteZahl)
        {
            if (zahl >= -10 && zahl <= 100)
            {
                if (abgefragteZahl == 1)
                {
                    ErsteZahl = zahl;
                }
                else
                {
                    ZweiteZahl = zahl;
                }
                ZahlGueltig = true;
            }
            else
            {
                ZahlGueltig = false;
            }

        }

        private double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;
            return summe;
        }


        private double Subtrahiere(double minunend, double subtrahent)
        {
            double differenz = minunend - subtrahent;
            return differenz;
        }

        private double Multipliziere(double multiplikator, double multiplikant)
        {
            double produkt = multiplikator * multiplikant;
            return produkt;
        }

        private double Dividiere(double dividend, double divisor)
        {

            double quotient = dividend / divisor;
            return quotient;
        }
    }
}
