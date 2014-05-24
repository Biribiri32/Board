using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellDeck.CardFiles
{
    public class SpellCardDeck : List<SpellCard>
    {
        public SpellCardDeck() { }

        public void PrintDeck(bool showShort)
        {
            foreach (SpellCard card in this)
            {
                Console.WriteLine(card.ToString(showShort));
            }
        }
    }

     public static class SpellDeckOperations
     {
         public static void Shuffle<T>(this IList<T> list)
         {
             Random rng = new Random();

             int n = list.Count;

             while (n > 1)
             {
                 n--;
                 int k = rng.Next(n + 1);
                 T value = list[k];
                 list[k] = list[n];
                 list[n] = value;
             }
         }
     }
}
