using System;

namespace Taschenrechner
{
    class AnwendungsController
    {
        private ConsoleView view;
        private RechnerModel model;

        public AnwendungsController(ConsoleView view, RechnerModel model)
        {
            this.view = view;
            this.model = model;

        }

        public void Ausfuehren()
        {
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
