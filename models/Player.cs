using System;
using System.Collections.Generic;

namespace deckofcards.models
{
    public class Player
    {
        public string Name;
        public List<Card> hand = new List<Card>{};

        public Deck playerDeck = new Deck();
        public Player(string name)
        {
            Name = name;
        }

        public Player DrawCard(Deck playerDeck)
        {
            System.Console.WriteLine("Drawing Card...");
            hand.Add(playerDeck.cards[0]);
            playerDeck.PickCard();
            Console.ForegroundColor = ConsoleColor.Magenta;
            System.Console.WriteLine($"***** {Name} has Drawn *****");

            return this;
            
        }
        public void showHand()
        {
            if(hand.Count==0)
            {
                System.Console.WriteLine($"{Name}'s hand is empty");
            }
            else 
            {   Console.ForegroundColor = ConsoleColor.DarkCyan;
                System.Console.WriteLine($"{Name} has {hand.Count} cards:");
                foreach (Card card in hand)
                {
                    card.ReadCard();
                }

            }
        }
        public Player Discard(int index)
        {
            if (hand.Count==0)
            {
                System.Console.WriteLine($"{Name} has nothing to discard");
            }
            else
            {    
                if (index > hand.Count-1)
                {    
                    return null;
                }
                else 
                {
                    System.Console.Write($"{Name} discarded ");
                    hand[index].ReadCard();
                    hand.RemoveAt(index);

                }
            }
            return this;
        }
    }

}