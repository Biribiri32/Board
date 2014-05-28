using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellDeck.CardFiles
{
    public abstract class Card
    {
        public enum CardState
        {
            Deck,
            Hand,
            Discard
        };

        public string CardId { get; set; }

        public string Name { get; set; }

        public int Cost { get; set; }

        public string Effect { get; set; }

        public double Probablilty { get; set; }

        public int MaxCopiesOfCard { get; set; }

        public ProportionValue<SpellCard> Proportion { get; set; }

        public CardState CardStatus { get; set; }
    }
}
