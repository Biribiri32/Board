using ClassManager.ClassComponents;
using ClassManager.GameClasses.MagicalGirl;
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

        ConsoleLogic _logic = new ConsoleLogic();

        public UserInputInterpreter()
        {

        }

        public void Interpreter(string command)
        {
            switch(command.ToUpper())
            {
                case "RUN":
                    _logic.RunGame();
                    break;
                case "DECK":
                    _logic.DeckManager(_manager);
                    break;
                case "CLASS":
                    _logic.SelectClass();
                    break;
            }
        }

        public GameClass ClassInterpreter(string command)
        {
            switch(command.ToUpper().Replace(" ", string.Empty))
            {
                case "MG":
                case "MAGICALGIRL":
                    return new MagicalGirl();
            }

            return null;
        }
    }
}
