using SpellDeck.CardFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellDeck.SpellDeckTests
{
    public class CardData
    {
        public SpellCardDeck ClassSpellDeck { get; set; }

        public List<ProportionValue<SpellCard>> Proportions { get; set; }

        public Dictionary<string, int> CardsUsedByID { get; set; }

        public CardData(SpellCardDeck deckToGenerate)
        {
            ClassSpellDeck = deckToGenerate;

            Proportions = new List<ProportionValue<SpellCard>>();
            CardsUsedByID = new Dictionary<string, int>();

            foreach(SpellCard card in ClassSpellDeck)
            {
                Proportions.Add(card.Proportion);

                CardsUsedByID.Add(card.CardId, card.MaxCopiesOfCard);
            }
        }

        public SpellCard GetSpellCardByID(string id)
        {
            return ClassSpellDeck.FirstOrDefault(c => c.CardId == id);
        }
        
    }
}
