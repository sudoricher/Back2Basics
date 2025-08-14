using System;

namespace Back2Basics
{
    internal partial class Program
    {
        
            public class ClassCompSelection {
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
            }
    }       
}
