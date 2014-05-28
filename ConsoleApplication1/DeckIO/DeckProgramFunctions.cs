using SpellDeck.CardFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellDeck
{
    public class DeckProgramFunctions
    {
        SpellDeckCardGenerator generator = new SpellDeckCardGenerator();

        public void Generate(ref bool done, ref bool showShort)
        {
            Console.Write(SpellDeckConsoleMessages.SHORT_LENGTH_PROMPT);

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
            }

            generator.GeneratedDeck.PrintDeck(showShort);

            Console.WriteLine(SpellDeckConsoleMessages.POST_DECK_MESSAGE, generator.TotalCardsGenerated, generator.AverageCost, generator.HighestCost);

            //Console.WriteLine(SpellDeckConsoleMessages.SHUFFLE_DECK);

            //SpellDeckOperations.Shuffle(generator.GeneratedDeck);

            //generator.GeneratedDeck.PrintDeck(showShort);

            Console.Write(SpellDeckConsoleMessages.NAME_DECK);

            generator.GeneratedDeck.DeckName = Console.ReadLine();

            DeckSaver.Save(generator.GeneratedDeck);
        }

        public void Load(ref bool done, ref bool showShort)
        {
            Console.Write(SpellDeckConsoleMessages.LOAD_DECK);

            string deckName = Console.ReadLine();

            SpellCardDeck loadedDeck = null;

            try
            {
                loadedDeck = DeckLoader.Load(deckName);

                loadedDeck.PrintDeck(showShort);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine(SpellDeckConsoleMessages.LOAD_DECK_ERROR);

                Load(ref done, ref showShort);
            }
        }
    }
}
