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
            model.ErsteZahl = HoleZahlVomBenutzer();
            model.Operation = HoleOperatorVomBenutzer();
            model.ZweiteZahl = HoleZahlVomBenutzer();
        }

        public void HoleEingabenFuerFortlaufendeBerechnung()
        {
            model.Operation = HoleOperatorVomBenutzer();
            string eingabe = HoleNaechsteAktionVomBenutzer();


            if (eingabe.ToUpper() == "FERTIG")
            {
                BenutzerWillBeenden = true;
            }
            else
            {
                model.ErsteZahl = model.Resultat;
                model.ZweiteZahl = Convert.ToDouble(eingabe);
            }
        }

        private string HoleNaechsteAktionVomBenutzer()
        {
            Console.Write("Bitte gib eine weitere Zahl ein (Fertig zum Beenden): ");
            return Console.ReadLine();
        }


        private double HoleZahlVomBenutzer()
        {
            string eingabe;
            double zahl;
            Console.Write("Bitte gib eine Zahl für die Berechnung ein: ");
            eingabe = Console.ReadLine();



            while (!double.TryParse(eingabe, out zahl) && eingabe.ToUpper() != "FERTIG")
            {
                Console.WriteLine("Du musst eine gültige Gleitkommazahl eingeben!");
                Console.WriteLine("Neben den Ziffern 0-9 sind lediglich die folgenden Sonderzeichen erlaubt: ,.-");
                Console.WriteLine("Dabei muss das - als erstes Zeichen vor einer Ziffer gesetzt werden.");
                Console.WriteLine("Der . fungiert als Trennzeichen an Tausenderstellen.");
                Console.WriteLine("Das , ist das Trennzeichen für die Nachkommastellen.");
                Console.WriteLine("Alle drei Sonderzeichen sind optional!");
                Console.WriteLine();
                Console.Write("Bitte gib erneut eine Zahl für die Berechnung ein: ");
                eingabe = Console.ReadLine();
            }

            return zahl;
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
