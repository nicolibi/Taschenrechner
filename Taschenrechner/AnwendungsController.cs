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
            view.HoleEingabenFuerBerechnungVomBenutzer(true);
            //model.Berechne();
            //view.GibResultatAus();
            //view.HoleEingabenFuerBerechnungVomBenutzer();

            while (!(model.AktuellerStatus == Status.BeendigungDurchBenutzer))
            {
                model.Berechne();
                view.GibResultatAus();
                view.HoleEingabenFuerBerechnungVomBenutzer();
            }

        }



    }
}
