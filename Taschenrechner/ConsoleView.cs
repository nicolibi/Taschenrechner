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

        public void HoleEingabeVomBenutzer()
        {
            model.ErsteZahl = HoleZahlVomBenutzer();
            model.Operation = HoleOperatorVomBenutzer();
            model.ZweiteZahl = HoleZahlVomBenutzer();
        }

        private double HoleZahlVomBenutzer()
        {
            string eingabe;
            Console.Write("Bitte gib eine Zahl für die Berechnung ein (FERTIG zum Beenden): ");
            eingabe = Console.ReadLine();

            if (eingabe == "FERTIG")
            {
                BenutzerWillBeenden = true;
                eingabe = "0,0";
            }

            return Convert.ToDouble(eingabe);
        }


        private string HoleOperatorVomBenutzer()
        {
            Console.Write("Bitte gib eine Operation ein (+,-,*,/): ");
            return Console.ReadLine();
        }

        public void WarteAufEndeDurchBenutzer()
        {
            Console.WriteLine("Bitte drücke die ReturnTaste zum Beenden");
            Console.ReadLine();
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
