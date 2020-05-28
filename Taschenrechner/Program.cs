namespace Taschenrechner
{
    class Program
    {
        public static void Main()
        {
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);
            AnwendungsController controler = new AnwendungsController(view, model);

            controler.Ausfuehren();

        }

    }



}
