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
        public SpellCardDeck TestSpellDeck { get; set; }

        public List<ProportionValue<SpellCard>> Proportions { get; set; }

        public Dictionary<string, int> CardsUsedByID { get; set; }

        public CardData()
        {
            TestSpellDeck = new SpellCardDeck()
            {
                new SpellCard("AA-C-0001", "Fireball", 2, "Does 3 Damage to target.", 0.4, 10),
                new SpellCard("AA-U-0002", "Aether Flow", 1, "Draw a card. Increase Aether by 1.", 0.2, 4),
                new SpellCard("AA-C-0003", "Flame Nova", 4, "Does 2 Damage to all area around the Aether Adept.", 0.6, 4),
                new SpellCard("AA-R-0004", "Permafrost", 7, "Freeze the target in place for 2 turns.", 0.7, 2),
                new SpellCard("AA-C-0005", "Damage Ward", 3, "Shields the Aether Mage from 10 damage.", 0.3, 4),
                new SpellCard("AA-C-0006", "Ice Shiv", 1, "Melee Range. Stab target for 1 damage.", 0.3, 8),
                new SpellCard("AA-R-0007", "Clearcast", 5, "Next card cast has no cost.", 0.7, 2),
                new SpellCard("AA-U-0008", "Burn", 3, "Deal 3 damage over 3 turns to target.", 0.4, 6),
            };

            SpellDeckOperations.Shuffle(TestSpellDeck);

            Proportions = new List<ProportionValue<SpellCard>>();
            CardsUsedByID = new Dictionary<string, int>();

            foreach(SpellCard card in TestSpellDeck)
            {
                Proportions.Add(card.Proportion);

                CardsUsedByID.Add(card.CardId, card.MaxCopiesOfCard);
            }
        }

        public SpellCard GetSpellCardByID(string id)
        {
            return TestSpellDeck.FirstOrDefault(c => c.CardId == id);
        }
        
    }
}
