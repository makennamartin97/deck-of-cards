using System;
namespace deckofcards.models
{
    public class Card
    {
        public string stringVal;
        public string Suit;
        public int Value;

        public Card(string stringval, string suit, int val)
        {
            stringVal = stringval;
            Suit = suit;
            Value = val;
        }
        public void ReadCard()
        {
            System.Console.WriteLine($" {stringVal} of {Suit}");
        }
    }
}