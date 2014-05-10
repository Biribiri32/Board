using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellDeck
{
    public class SpellCard : Card
    {
        public SpellCard(string cardId, string name, int cost, string effect)
        {
            this.CardId = cardId;
            this.Name = name;
            this.Cost = cost;
            this.Effect = effect;
        }

        public string ToString(bool shortForm)
        {
            if (shortForm)
            {
                return string.Format("Card ID: {0} | Name: {1}",
                    this.CardId, this.Name);
            }
            else
            {
                return string.Format("Card ID: {0} | Name: {1} | Cost: {2} | Effect: {3}\n",
                    this.CardId, this.Name, this.Cost, this.Effect);
            }
        }
    }
}
