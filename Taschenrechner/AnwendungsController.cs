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

            while (!view.BenutzerWillBeenden)
            {
                view.HoleEingabeVomBenutzer();

                //Berechnung ausführen

                model.Berechne();

                //Ausgabe

                view.GibResultatAus();
            }

            view.WarteAufEndeDurchBenutzer();
        }



    }
}
