using System;

namespace Taschenrechner
{
    class ConsoleView
    {
        public string HoleBenutzereingabe(string ausgabetext)
        {
            Console.Write(ausgabetext);
            string summand = Console.ReadLine();
            return summand;
        }


        public void GibResultatAus(double resultat, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Die Summe ist {0}", resultat);
                    break;
                case "-":
                    Console.WriteLine("Die Differenz ist {0}", resultat);
                    break;

                case "*":
                    Console.WriteLine("Das Produkt ist {0}", resultat);
                    break;

                case "/":
                    Console.WriteLine("Der Quotient ist {0}", resultat);
                    break;

                default:
                    Console.WriteLine("Die Operation ist noch nicht implementiert oder ungültig");
                    break;
            }


        }

    }
}
