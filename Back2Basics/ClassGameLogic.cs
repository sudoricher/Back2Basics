using System;

namespace Back2Basics
{
    internal partial class Program
    {
        public class ClassGameLogic
        {
            public static void GameLogic()
            {
                string userCard;
                string compCard;
                int chances;
                int tries;
                string playAgain = "x";

                while (playAgain == "x")
                {
                    userCard = ClassUserSelection.UserSelection();
                    for (chances = 20; chances > 0; chances--)
                    {
                        compCard = ClassCompSelection.CompSelection();
                        if (compCard == userCard)
                        {
                            Console.WriteLine($"The user chose {userCard}");
                            Console.WriteLine($"The computer chose {compCard}");
                            tries = 20 - chances;
                            if (tries == 0)
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
