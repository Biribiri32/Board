using ClassManager.ClassComponents;
using GameConsole.ConsoleCommands;
using SpellDeck;
using SpellDeck.DeckIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.ConsoleComponents
{
    public class ConsoleLogic
    {
        // Start at Home
        private string Location = MainConsoleMessages.LOC_HOME;

        private GameClass CurrentClass;

        UserInputInterpreter _interpreter;

        DeckGenerator _generator;

        public void RunConsole()
        {
            Welcome();
        }

        private void Welcome()
        {
            _interpreter = new UserInputInterpreter();

            while (true)
            {
                Console.Write(MainConsoleMessages.PROMPT, Location);

                _interpreter.Interpreter(Console.ReadLine());
            }
        }

        public void RunGame()
        {

        }

        public void DeckManager(ConsoleDeckManager manager)
        {
            bool closeManager = false;

            if (SelectClass())
            {
                _generator = new DeckGenerator(CurrentClass);

                DeckProgramFunctions func = new DeckProgramFunctions(_generator.GetGenerator());

                while (!closeManager)
                {
                    closeManager = manager.RunDeckManager(func);
                }
            }
        }

        public bool SelectClass()
        {
            _interpreter = new UserInputInterpreter();

            Console.Write(MainConsoleMessages.CLASS_SELECT_MESSAGE);

            GameClass value = _interpreter.ClassInterpreter(Console.ReadLine()); 

            if(value != null)
            {
                CurrentClass = value;

                Console.Write(MainConsoleMessages.CURR_CLASS, CurrentClass.Name);

                return true;
            }
            else 
            {
                Console.Write(MainConsoleMessages.CLASS_SELECT_MESSAGE_ERROR);
            }

            return false;
        }
    }
}
