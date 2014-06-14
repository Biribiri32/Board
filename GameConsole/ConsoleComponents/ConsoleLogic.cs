using GameConsole.ConsoleCommands;
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

        UserInputInterpreter _interpreter = new UserInputInterpreter();

        public void RunConsole()
        {
            Welcome();
        }

        private void Welcome()
        {
            while (true)
            {
                Console.Write(MainConsoleMessages.PROMPT, Location);

                _interpreter.Interpreter(Console.ReadLine());
            }
        }

        public static void RunGame()
        {

        }

        public static void DeckManager(ConsoleDeckManager manager)
        {
            bool closeManager = false;

            while (!closeManager)
            {
                closeManager = manager.RunDeckManager();
            }
        }
    }
}
