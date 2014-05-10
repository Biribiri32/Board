using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellDeck
{
    public abstract class Card
    {
        public string CardId { get; set; }

        public string Name { get; set; }

        public int Cost { get; set; }

        public string Effect { get; set; }
    }
}
