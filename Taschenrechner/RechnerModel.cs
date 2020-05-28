using System;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }
        public string Operation { get; private set; }
        public RechnerModel()
        {
            Resultat = 0;
            Operation = "unbekannt";
        }

        public void Berechne(double ersteZahl, double zweiteZahl, string operation)
        {
            this.Operation = operation;

            switch (operation)
            {
                case "+":
                    Resultat = Addiere(ersteZahl, zweiteZahl);
                    break;

                case "-":
                    Resultat = Subtrahiere(ersteZahl, zweiteZahl);
                    break;

                case "/":
                    Resultat = Dividiere(ersteZahl, zweiteZahl);
                    break;


                case "*":
                    Resultat = Multipliziere(ersteZahl, zweiteZahl);
                    break;


                default:
                    Console.WriteLine("Du hast eine ungültige Auswahl für die Operation getroffen");
                    break;
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
