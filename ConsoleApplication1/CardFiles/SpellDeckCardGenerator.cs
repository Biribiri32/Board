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

            GenerateDeck();
        }

        //private SpellCard GetRandomSpellCard()
        //{
        //    //return data.TestSpellDeck[random.Next(0, data.TestSpellDeck.Count)];
        //    //return data.Proportions
        //}

        private void GenerateDeck()
        {
            for (int cardNum = 0; cardNum < SpellDeckParameters.MAX_DECK_SIZE; cardNum++ )
            {
                SpellCard randomCard = GetRandomSpellCard();

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
            return ProportionValue.ChooseByRandom(data.Proportions);
        }
    }
}
