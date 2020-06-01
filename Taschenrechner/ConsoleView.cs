using System;

namespace Taschenrechner
{
    class ConsoleView
    {

        private RechnerModel model;
        public bool BenutzerWillBeenden = false;
        public ConsoleView(RechnerModel model)
        {
            this.model = model;
        }

        private void HoleZahlVomBenutzer(int abgefragteZahl)
        {
            string eingabe;
            eingabe = FrageZahlvonBenutzerAb();
            PruefeEingegebenenZahlenwert(eingabe, abgefragteZahl);
        }
        public void HoleEingabenFuerBerechnungVomBenutzer(bool ersteAbfrage = false)
        {
            if (ersteAbfrage)
            {
                HoleZahlVomBenutzer(1);
            }
            else
            {
                model.ErsteZahl = model.Resultat;
            }

            HoleOperatorVomBenutzer();

            if (!(model.AktuellerStatus == Status.BeendigungDurchBenutzer))
            {

                HoleZahlVomBenutzer(2);
            }

        }


        private string FrageZahlvonBenutzerAb()
        {
            Console.Write("Bitte gib eine Zahl ein (FERTIG zum Beenden): ");
            return Console.ReadLine();
        }


        private void HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte gib eine Operation ein (+,-,*,/), # für Abbruch : ");
            model.Operation = Console.ReadLine();

            while (model.AktuellerStatus == Status.UngueltigeOperation)
            {
                Console.WriteLine("Die letzte Eingabe für die Operation war leider ungültig.");
                Console.Write("Bitte gib eine Operation ein (+,-,*,/), # für Abbruch : ");
                model.Operation = Console.ReadLine();
            }

        }


        private void PruefeEingegebenenZahlenwert(string eingabe, int abgefragteZahl)
        {
            double zahl;

            do
            {
                if (double.TryParse(eingabe, out zahl))
                {
                    model.PruefeWertGueltig(zahl, abgefragteZahl);
                }
                else if (eingabe.ToUpper() == "FERTIG")
                {
                    model.AktuellerStatus = Status.BeendigungDurchBenutzer;
                }

                if (model.AktuellerStatus == Status.GrenzwertUeberschreitung)
                {
                    eingabe = WiederholeEingabe();
                }

            }
            while (eingabe.ToUpper() != "FERTIG" && !(model.AktuellerStatus == Status.OK));

        }

        public string WiederholeEingabe()
        {
            Console.WriteLine("Die letzte Eingabe war leider ungültig!!");
            Console.WriteLine("Du musst eine gültige Gleitkommazahl zwischen -10,0 und 100,0 eingeben!");
            Console.WriteLine("Neben den Ziffern 0-9 sind lediglich die folgenden Sonderzeichen erlaubt: ,.-");
            Console.WriteLine("Dabei muss das - als erstes Zeichen vor einer Ziffer gesetzt werden.");
            Console.WriteLine("Der . fungiert als Trennzeichen an Tausenderstellen.");
            Console.WriteLine("Das , ist das Trennzeichen für die Nachkommastellen.");
            Console.WriteLine("Alle drei Sonderzeichen sind optional!");
            Console.WriteLine();
            Console.Write("Bitte gib erneut eine Zahl für die Berechnung ein (FERTIG zum Beenden): ");
            return Console.ReadLine();
        }



        public void GibResultatAus()
        {
            switch (model.Operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist {0}", model.Resultat);
                    break;
                case "-":
                    Console.WriteLine("Die Differenz ist {0}", model.Resultat);
                    break;

                case "*":
                    Console.WriteLine("Das Produkt ist {0}", model.Resultat);
                    break;

                case "/":
                    Console.WriteLine("Der Quotient ist {0}", model.Resultat);
                    break;

                default:
                    Console.WriteLine("Die Operation ist noch nicht implementiert oder ungültig");
                    break;
            }

        }

    }
}
