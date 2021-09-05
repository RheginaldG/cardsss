using System;
using System.Collections.Generic;

namespace cardsss
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namedcard = { "Ace", "Jack", "Queen", "King" };
            string[] suites = { "Hearts", "Diamond", "Clubs", "Spades" };
            List<string> deck = new List<string>();

            List<string> cards = new List<string>(namedcard);
            for (int i = 2; i <= 10; i++)
            {
                cards.Add(Convert.ToString(i));
            }

            //for (int i = 0; i<4; i++)
            //{
            //    for(int j = 0; j<cards.Count ; j++)
            //    {
            //        deck.Add(cards[j] + " of " + suites[i]);
            //    }
            //}

            foreach (string i in cards)
            {
                foreach(string j in suites)
                {
                    deck.Add(i + " of " + j); //Pair Machine
                }
            }

            foreach(string c in deck)
            {
                Console.WriteLine(c);
            }
        }
    }
}
