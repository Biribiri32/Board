using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellDeck.CardFiles
{
    public class SpellCardDeck : List<SpellCard>
    {
        public string DeckName { get; set; }

        public SpellCardDeck() { }

        public List<SpellCard> Draw(int numberOfCards)
        {
            List<SpellCard> retVal = new List<SpellCard>();

            int  selectedCards = 0, idx = 0;

            while(selectedCards <= numberOfCards)
            {
                SpellCard card = null;

                try
                {
                    card = this[idx];
                }
                catch(ArgumentOutOfRangeException)
                {
                    // Reset the deck
                    idx = 0;

                    SpellDeckOperations.Shuffle(this);
                }

                if (card != null && card.CardStatus == Card.CardState.Deck)
                {
                    card.CardStatus = Card.CardState.Hand;

                    retVal.Add(card);

                    selectedCards++;
                }
                else
                {
                    idx++;
                }

            }

            return retVal;
        }

        public void PrintDeck(bool showShort)
        {
            foreach (SpellCard card in this)
            {
                Console.WriteLine(card.ToString(showShort));
            }
        }
    }

     public static class SpellDeckOperations
     {
         public static void Shuffle<T>(this IList<T> deck)
         {
             Random rng = new Random();

             int n = deck.Count;

             while (n > 1)
             {
                 n--;
                 int k = rng.Next(n + 1);
                 T value = deck[k];
                 deck[k] = deck[n];
                 deck[n] = value;
             }

             foreach(SpellCard card in (List<SpellCard>)deck)
             {
                 card.CardStatus = Card.CardState.Deck;
             }
         }
     }
}
