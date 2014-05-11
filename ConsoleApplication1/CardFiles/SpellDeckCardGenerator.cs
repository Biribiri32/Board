using SpellDeck.SpellDeckTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellDeck.CardFiles
{
    public class SpellDeckCardGenerator
    {
        public SpellCardDeck GeneratedDeck { get; set; }

        public int TotalCardsGenerated { get; set; }

        public int AverageCost { get; set; }

        public int HighestCost { get; set; }

        public Dictionary<string, int> CurrentCardsUsedByID { get; set; }

        private CardData data;
        private Random random;

        public SpellDeckCardGenerator()
        {
            random = new Random();
            data = new CardData();

            GeneratedDeck = new SpellCardDeck();
            TotalCardsGenerated = 0;
            AverageCost = 0;
            HighestCost = 0;

            InitilizeCurrentCardsUsedById();

            GenerateDeck();
        }

        private void InitilizeCurrentCardsUsedById()
        {
            CurrentCardsUsedByID = new Dictionary<string, int>();

            foreach(SpellCard card in data.TestSpellDeck)
            {
                CurrentCardsUsedByID.Add(card.CardId, 0);
            }
        }

        private void GenerateDeck()
        {
            for (int cardNum = 0; cardNum < SpellDeckParameters.MAX_DECK_SIZE; cardNum++ )
            {
                SpellCard randomCard = null;

                while(randomCard == null)
                {
                    randomCard = GetRandomSpellCard();
                }

                int randomCost = randomCard.Cost;

                AverageCost += randomCost;

                DetermineHighestCost(randomCost);

                GeneratedDeck.Add(randomCard);

                TotalCardsGenerated++;
            }

            GetAverage();
        }

        private void DetermineHighestCost(int cost)
        {
            HighestCost = cost > HighestCost ? cost : HighestCost;  
        }

        private void GetAverage()
        {
            AverageCost = AverageCost / SpellDeckParameters.MAX_DECK_SIZE;
        }

        public SpellCard GetRandomSpellCard()
        {
            SpellCard returnCard = null;
            int CurrentNumberUsed = 0, MaxValueUsed = 0;

            while (returnCard == null)
            {
                SpellCard cardTemp = ProportionValue.ChooseByRandom(data.Proportions);

                CurrentCardsUsedByID.TryGetValue(cardTemp.CardId, out CurrentNumberUsed);
                data.CardsUsedByID.TryGetValue(cardTemp.CardId, out MaxValueUsed);

                if (CurrentNumberUsed < MaxValueUsed)
                {
                    CurrentCardsUsedByID[cardTemp.CardId]++;

                    returnCard = cardTemp;
                }
                else if (CurrentNumberUsed == MaxValueUsed)
                {
                    var temp = data.Proportions.Find(p => p == cardTemp.Proportion);

                    // Don't generate anymore of this card.
                    temp.Proportion = 0.0;

                    break;
                }
            }

            return returnCard;
        }
    }
}
