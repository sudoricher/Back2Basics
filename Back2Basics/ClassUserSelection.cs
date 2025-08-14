using System;

namespace Back2Basics
{
    internal partial class Program
    {
        public class ClassUserSelection
        {
            public static string UserSelection()
            {
                Console.WriteLine("-----Select ace, number or face card----- ");
                Console.Write("Please write the card in full(except for number cards): ");
                string selectedCard = Console.ReadLine();
                Console.WriteLine("-----Select a symbol----- ");
                Console.Write("Please write the symbol in full: ");
                string selectedSymbol = Console.ReadLine();
                string userCard = selectedCard.ToUpper() + " of " + selectedSymbol.ToUpper();

                return userCard;

            }
        }
    }       
}
