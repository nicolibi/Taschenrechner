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

        public void HoleEingabenFuerErsteBerechnungVomBenutzer()
        {
            HoleZahlVomBenutzer(1);
            model.Operation = HoleOperatorVomBenutzer();
            HoleZahlVomBenutzer(2);
        }

        public void HoleEingabenFuerFortlaufendeBerechnung()
        {
            model.ErsteZahl = model.Resultat;
            model.Operation = HoleOperatorVomBenutzer();


            string eingabe = FrageZahlvonBenutzerAb();
            PruefeEingabeAufGueltigkeit(eingabe, 2);
        }

        private string FrageZahlvonBenutzerAb()
        {
            Console.Write("Bitte gib eine Zahl ein (FERTIG zum Beenden): ");
            return Console.ReadLine();
        }

        private void HoleZahlVomBenutzer(int abgefragteZahl)
        {
            string eingabe;
            eingabe = FrageZahlvonBenutzerAb();
            PruefeEingabeAufGueltigkeit(eingabe, abgefragteZahl);
        }




        private void PruefeEingabeAufGueltigkeit(string eingabe, int abgefragteZahl)
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
                    BenutzerWillBeenden = true;

                }
                else if (!model.ZahlGueltig)
                {
                    eingabe = WiederholeEingabe();

                }

            }
            while (eingabe.ToUpper() != "FERTIG" && !model.ZahlGueltig);

        }

        public string WiederholeEingabe()
        {
            Console.WriteLine("Du musst eine gültige Gleitkommazahl zwischen -10,0 und 100,0 eingeben!");
            Console.WriteLine("Neben den Ziffern 0-9 sind lediglich die folgenden Sonderzeichen erlaubt: ,.-");
            Console.WriteLine("Dabei muss das - als erstes Zeichen vor einer Ziffer gesetzt werden.");
            Console.WriteLine("Der . fungiert als Trennzeichen an Tausenderstellen.");
            Console.WriteLine("Das , ist das Trennzeichen für die Nachkommastellen.");
            Console.WriteLine("Alle drei Sonderzeichen sind optional!");
            Console.WriteLine();
            Console.Write("Bitte gib erneut eine Zahl für die Berechnung ein: ");
            return Console.ReadLine();
        }

        private string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte gib eine Operation ein (+,-,*,/): ");
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
