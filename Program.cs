using System;

namespace deckofcards.models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine("******************************** Starting Game *********************************");
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Directions: After drawing 5 cards each, the first player to have 3 cards of the same suit wins. Players may discard and draw a new card once per turn.");



            Deck d = new Deck();
            Player p1 = new Player("Makenna");
            Player p2 = new Player("Hunter");

            d.Shuffle();
            //d1.PickCard();
            //d1.Reset();
            //Console.WriteLine(d1.cards.Count);

            p1.DrawCard(d);
            p1.DrawCard(d);
            p1.DrawCard(d);
            p1.DrawCard(d);
            p1.DrawCard(d);

            p1.showHand();

            p2.DrawCard(d);
            p2.DrawCard(d);
            p2.DrawCard(d);
            p2.DrawCard(d);
            p2.DrawCard(d);

            p2.showHand();

            p1.Discard(2);
            p1.DrawCard(d);
            p1.showHand();

            p2.Discard(3);
            p2.DrawCard(d);
            p2.showHand();

            d.Shuffle();
            d.Reset();



            

        






        }
    }
}
