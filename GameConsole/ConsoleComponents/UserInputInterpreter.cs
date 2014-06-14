using GameConsole.ConsoleComponents;
using SpellDeck.DeckIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.ConsoleCommands
{
    public class UserInputInterpreter
    {
        ConsoleDeckManager _manager = new ConsoleDeckManager();

        public void Interpreter(string command)
        {
            switch(command.ToUpper())
            {
                case "RUN":
                    ConsoleLogic.RunGame();
                    break;
                case "DECK":
                    ConsoleLogic.DeckManager(_manager);
                    break;
                case "CLASS":
                    break;
            }
        }
    }
}
