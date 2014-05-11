using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellDeck.CardFiles
{
    public class SpellCard : Card
    {
        public SpellCard(string cardId, string name, int cost, string effect, double probability)
        {
            this.CardId = cardId;
            this.Name = name;
            this.Cost = cost;
            this.Effect = effect;
            this.Probablilty = probability;

            this.Proportion = ProportionValue.Create(this.Probablilty, this);
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
                return string.Format("Card ID: {0} | Name: {1} | Cost: {2} | Effect: {3} | Probability: {4}\n",
                    this.CardId, this.Name, this.Cost, this.Effect, this.Probablilty);
            }
        }
    }
}
