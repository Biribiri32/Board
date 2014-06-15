using ClassManager.ClassComponents;
using SpellDeck.CardFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManager.GameClasses.MagicalGirl
{
    public class MagicalGirl : GameClass, IGameClass<MagicalGirl>
    {
        public MagicalGirl()
        {
            Name = "Magical Girl";
            Description = "Blah";
            Type = GameClass.GameClassType.Magical_Girl;
            Keywords = GameClassKeywords.Caster | GameClassKeywords.Ranged;

            SetCardData();
        }

        public void SetCardData()
        {
            // ID - Name - Cost - Description - Generation Chance - Max copies of card
            Deck = new SpellCardDeck()
            {
                new SpellCard("MG-C-0001", "Sonic Blast", 2, "Does 2 damage to target", 0.6, 6),
                new SpellCard("MG-C-0002", "Friendship", 3, "Draw 2 cards", 0.6, 6),
                new SpellCard("MG-C-0003", "Sonic Kick", 2, "Melee Range. Kick target for 3 damage.", 0.6, 6),
                new SpellCard("MG-U-0004", "Transform", 4, "Transforms the Magical Girl for 3 turns.", 0.6, 4),
                new SpellCard("MG-U-0005", "Star Stream", 5, "Does 5 damage to target. Deals 8 damage if transformed.", 0.5, 4),
                new SpellCard("MG-U-0006", "Sonic Wave", 5, "Does 3 damage to area around the Magical girl. 4 damage if transformed.", 0.5, 4),
                new SpellCard("MG-R-0007", "Fly", 8, "Increases Movement Range.", 0.4, 4),
                new SpellCard("MG-R-0008", "Summon: Mascot", 6, "Summons a random mascot character.", 0.4, 3),
                new SpellCard("MG-R-0009", "Moe Moe Kyun", 7, "Stuns nearby enemies for 2 turn(s).", 0.4, 3),
                new SpellCard("MG-RR-0010", "Ultimate Sacrifice", 10, "Ultimate. Requires Transformation." +
                                "Deals 10 damage to all enemies and heals 10 damage from all allies.", 0.3, 2),
            };
        }

        //public bool Equals(MagicalGirl gameClass)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
