using System;

namespace Taschenrechner
{
    public enum Status
    {
        OK,
        GrenzwertUeberschreitung,
        UngueltigeOperation,
        BeendigungDurchBenutzer

    }
    public class RechnerModel
    {
        public double Resultat { get; private set; }
        public static double ObererGrenzwert { get { return 100.0; } }
        public static double UntererGrenzwert { get { return -10.0; } }

        private string operation = "undefiniert";
        public string Operation
        {
            get
            { return operation; }

            set
            {
                // Wir ändern den Wert der Eigenschaft nur, wenn ein anderer Wert
                // zugewiesen wird
                if (value != operation)
                {
                    switch (value)
                    {
                        case "#":
                            AktuellerStatus = Status.BeendigungDurchBenutzer;
                            operation = value;
                            break;
                        case "+":
                        case "-":
                        case "/":
                        case "*":
                            // Es wurde eine gültige Operation übergeben. Daher können wir
                            // den Fehler zurücksetzen ...
                            if (AktuellerStatus == Status.UngueltigeOperation)
                            {
                                AktuellerStatus = Status.OK;
                            }
                            // ... und den neuen Operator verwenden
                            operation = value;
                            break;
                        default:
                            // Die übergebene Operation wird nicht unterstützt. Daher wird 
                            // angezeigt, dass ein Fehler anliegt und auch die operation zeigt
                            // an, dass etwas nicht stimmt.
                            operation = "ungueltig";
                            AktuellerStatus = Status.UngueltigeOperation;
                            break;
                    }

                }
            }
        }

        public double ErsteZahl { get; set; }

        public double ZweiteZahl { get; set; }
        public bool ZahlGueltig = false;
        public Status AktuellerStatus { get; internal set; }


        public RechnerModel()
        {
            Resultat = 0;
            Operation = "undefiniert";
            AktuellerStatus = Status.OK;
        }

        public void Berechne()
        {
            //this.Operation = Operation;

            if (AktuellerStatus != Status.OK)
            {
                return;
            }

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

                case "#":
                    Console.WriteLine("Der Taschenrechner wird beendet");
                    break;

                default:
                    AktuellerStatus = Status.UngueltigeOperation;
                    Console.WriteLine("Du hast eine ungültige Auswahl für die Operation getroffen");
                    break;
            }

        }

        public Status PruefeWertGueltig(double zahl, int abgefragteZahl)
        {
            if (zahl >= UntererGrenzwert && zahl <= ObererGrenzwert)
            {
                if (abgefragteZahl == 1)
                {
                    ErsteZahl = zahl;
                }
                else
                {
                    ZweiteZahl = zahl;
                }
                AktuellerStatus = Status.OK;
            }
            else
            {
                AktuellerStatus = Status.GrenzwertUeberschreitung;
            }

            return AktuellerStatus;
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
