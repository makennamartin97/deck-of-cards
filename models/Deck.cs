using System;
using System.Collections.Generic;
namespace deckofcards.models
{
    public class Deck
    {
        public List<Card> cards = new List<Card>{};

        public Deck()
        {
            string[] stringvals = new string[] {"Ace", "2", "3","4", "5" , "6", "7","8","9","10", "Jack", "Queen", "King"};
            string[] suits = new string[] {"Clubs", "Spades", "Hearts", "Diamonds"};
           

            for(int j = 0; j < suits.Length; j++)
            {
                for(int i = 0; i < stringvals.Length; i++)
                {
                    cards.Add(new Card(stringvals[i], suits[j], i+1));
                }
            }
        }
        public Deck PickCard()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("Picking card...");
            if (cards.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Console.WriteLine("***** Out of cards *****");
            }
            else{
                Console.ForegroundColor = ConsoleColor.Magenta;
                System.Console.WriteLine("***** Card is Drawn *****");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                System.Console.WriteLine($"There are now {cards.Count} cards left in the stack");
                //System.Console.WriteLine($"You have drawn: {cards[0].stringVal} of {cards[0].Suit}");
                cards.Remove(cards[0]);
            }
            return this;
        }
        public Deck Shuffle()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("Shuffling Deck...");
            Random rand = new Random();
            for(int i = 0; i < cards.Count; i++)
            {
                int index = rand.Next(cards.Count);
                Card temp = cards[i];
                cards[i] = cards[index];
                cards[index] = temp;
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            System.Console.WriteLine("***** Deck is Shuffled *****");
            return this;

        }
        public Deck Reset()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("Resetting Deck...");
            Deck newdeck = new Deck();
            cards = newdeck.cards;
            Console.ForegroundColor = ConsoleColor.Magenta;
            System.Console.WriteLine("***** Deck is Reset *****");
            return this;
        }


        
        
    }
}