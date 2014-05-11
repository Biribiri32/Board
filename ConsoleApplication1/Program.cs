using SpellDeck.CardFiles;
using SpellDeck.SpellDeckTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellDeck
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool showShort = false, done = false;

                Console.Write(SpellDeckConsoleMessages.WELCOME_MESSAGE);

                while (!done)
                {
                    switch (Console.ReadLine().ToUpper())
                    {
                        case "Y":
                        case "YES":
                            showShort = true;
                            done = true;
                            break;
                        case "N":
                        case "NO":
                            showShort = false;
                            done = true;
                            break;
                        default:
                            break;
                    }
                }

                SpellDeckCardGenerator generator = new SpellDeckCardGenerator();

                foreach (SpellCard card in generator.GeneratedDeck)
                {
                    Console.WriteLine(card.ToString(showShort));
                }

                Console.WriteLine(SpellDeckConsoleMessages.POST_DECK_MESSAGE, generator.TotalCardsGenerated, generator.AverageCost, generator.HighestCost);
            }

            //Console.ReadLine();
        }
    }
}
