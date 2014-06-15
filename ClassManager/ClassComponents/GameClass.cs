using SpellDeck.CardFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManager.ClassComponents
{
    public class GameClass
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public GameClassType Type { get; set; }

        public SpellCardDeck Deck { get; set; }

        public GameClassKeywords Keywords { get; set; }

        public enum GameClassType
        {
            Magical_Girl
        };

        public enum GameClassKeywords
        {
            Ranged,
            Caster
        };
    }
}
