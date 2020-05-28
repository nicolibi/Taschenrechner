using System;

namespace Taschenrechner
{
    class Program
    {
        public static void Main()
        {
            //Anlegen des ConsoleView Objekts
            ConsoleView console = new ConsoleView();

            //User Storys für Berechnungsoperationen, Abfrage der Oparatoren und Operation
            string ersteZahlalsString = console.HoleBenutzereingabe("Bitte gib die erste Zahl ein: ");
            string zweiteZahlalsTring = console.HoleBenutzereingabe("Bitte gib  die zweite Zahl ein: ");

            string operation = console.HoleBenutzereingabe("Welche Operation möchtest du ausführen (+ ,-, /, *)? ");

            //Konvertieren in Gleitkommazahl
            //TODO: Auslagern in Funktion wenn der Code umfangreicher wird
            double ersteZahl = Convert.ToDouble(ersteZahlalsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlalsTring);

            //Berechnung ausführen
            RechnerModel model = new RechnerModel();
            model.Berechne(ersteZahl, zweiteZahl, operation);

            //Ausgabe

            console.GibResultatAus(model.Resultat, operation);
            console.HoleBenutzereingabe("Zum Beenden bitte Enter Taste drücken");
        }

        /*
        static string HoleBenutzereingabe(string ausgabetext)
        {
            Console.Write(ausgabetext);
            string summand = Console.ReadLine();
            return summand;
        }


        static void GibResultatAus(double resultat, string operation)
        {
            Console.WriteLine("Das Resultat der Operation {0} hat den Wert {1}", operation, resultat);
        }*/

    }



}
