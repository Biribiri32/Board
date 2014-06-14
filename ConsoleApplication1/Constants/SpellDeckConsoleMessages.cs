using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellDeck
{
    public class SpellDeckConsoleMessages
    {
        public const string WELCOME_MESSAGE = "Welcome to RPG card generator.\n";

        public const string SHORT_LENGTH_PROMPT = "Show shortened card details? [Y/N]: ";

        public const string MENU = "Main Menu:\n" 
            + "[G/Gen]: Generate a new deck\n"
            + "[L/Load]: Load an existing deck\n"
            + "[E/EXIT]: Exit deck manager\n\n"
            + "Please make a choice: ";

        public const string GENERATOR_MESSAGE = "Aether Adept Spell Deck being generated...";

        public const string POST_DECK_MESSAGE = "---\nCards Generated: {0} | Average Cost: {1} | Highest Cost: {2}\n---";

        public const string SHUFFLE_DECK = "Shuffling Deck";

        public const string NAME_DECK = "Enter Deck Name: ";

        public const string LOAD_DECK = "Enter Deck Name to Load: ";

        public const string LOAD_DECK_ERROR = "Deck Not Found.";
    }
}
