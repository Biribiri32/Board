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

        public CardData()
        {
            TestSpellDeck = new SpellCardDeck()
            {
                new SpellCard("AA-C-0001", "Fireball", 2, "Does 3 Damage to target."),
                new SpellCard("AA-U-0002", "Aether Flow", 1, "Draw a card. Increase Aether by 1."),
                new SpellCard("AA-C-0003", "Flame Nova", 3, "Does 2 Damage to all area around the Aether Adept."),
                new SpellCard("AA-R-0004", "Permafrost", 7, "Freeze the target in place for 2 turns."),
                new SpellCard("AA-C-0005", "Damage Ward", 2, "Shields the Aether Mage from 25 damage."),
            };
        }
        
    }
}
