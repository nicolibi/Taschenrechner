using System;

namespace Taschenrechner
{
    class Program
    {
        public static void Main()
        {
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);

            //User Storys für Berechnungsoperationen, Abfrage der Oparatoren und Operation
            string ersteZahlalsString = view.HoleZahlVomBenutzer();
            string operation = view.HoleOperationVomBenutzer();
            string zweiteZahlalsTring = view.HoleZahlVomBenutzer();


            //Konvertieren in Gleitkommazahl
            //TODO: Auslagern in Funktion wenn der Code umfangreicher wird
            double ersteZahl = Convert.ToDouble(ersteZahlalsString);
            double zweiteZahl = Convert.ToDouble(zweiteZahlalsTring);

            //Berechnung ausführen

            model.Berechne(ersteZahl, zweiteZahl, operation);

            //Ausgabe

            view.GibResultatAus(operation);
            view.WarteAufEndeDurchBenutzer();
        }

    }



}
