using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Back2Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cards.GameLogic();
            //Cards.UserSelection();
            //LearningBasics.AbsoluteValue();
            //LearningBasics.Calculations();
            //LearningBasics.EmailChecker();
            //LearningBasics.AreaCalculator();
            //LearningBasics.Basics();
            //LearningBasics.Sum();
            //LearningBasics.Comments();
            //LearningBasics.DataTypes();
            //LearningBasics.Introduction();
        }
        public class Cards
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
            private static readonly Random random = new Random();
            public static string CompSelection()
            {
                
                string[] cards = { "ace", "king", "queen", "jack", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten" };
                string[] cardType = { "diamonds", "clubs", "hearts", "spades" };
                int indexCard = random.Next(cards.Length);
                int indexType = random.Next(cardType.Length);
                string compCard = cards[indexCard].ToUpper() + " of " + cardType[indexType].ToUpper();

                return compCard;
            }

            public static void GameLogic()
            {
                string userCard;
                string compCard;
                int chances;
                int tries;
                string playAgain = "x";

                while (playAgain == "x")
                { userCard = UserSelection();
                    for (chances = 20; chances > 0; chances--)
                    {
                        compCard = CompSelection();
                        if (compCard == userCard)
                        {
                            Console.WriteLine($"The user chose {userCard}");
                            Console.WriteLine($"The computer chose {compCard}");
                            tries = 20 - chances;
                            if (tries == 1)
                            {
                                Console.WriteLine($"The user has won with {tries + 1} attempt");
                            }
                            else
                            {
                                Console.WriteLine($"The user has won with {tries + 1} attempts");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"No match!!! attempts left {chances - 1}");
                            Console.WriteLine($"The computer chose {compCard}");
                            if (chances == 1)
                            {
                                Console.WriteLine($"The user chose {userCard}");
                                Console.WriteLine($"The computer chose {compCard}");
                                Console.WriteLine("You've lost this round");
                            }
                        }
                    }
                    Console.WriteLine("Press x to play again or enter to quit");
                    playAgain = Console.ReadLine();
                } 
            }

        }
    }       
}
