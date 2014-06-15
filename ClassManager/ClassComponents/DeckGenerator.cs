using ClassManager.GameClasses.MagicalGirl;
using SpellDeck.CardFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassManager.ClassComponents
{
    public class DeckGenerator
    {
        SpellDeckCardGenerator _generator;

        public DeckGenerator(GameClass gameClass)
        {
            _generator = new SpellDeckCardGenerator(gameClass.Deck);
        }

        public SpellDeckCardGenerator GetGenerator()
        {
            return _generator;
        }
    }
}
