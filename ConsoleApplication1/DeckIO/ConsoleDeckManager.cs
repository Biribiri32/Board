using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellDeck.DeckIO
{
    public class ConsoleDeckManager
    {
        public bool RunDeckManager(DeckProgramFunctions func)
        {
            bool done = false, showShort = true;

            while (true)
            {
                done = false;

                Console.Write(SpellDeckConsoleMessages.WELCOME_MESSAGE);

                while (!done)
                {
                    Console.Write(SpellDeckConsoleMessages.MENU);

                    switch (Console.ReadLine().ToUpper())
                    {
                        case "G":
                        case "GEN":
                            func.Generate(ref done, ref showShort);
                            Console.WriteLine();
                            break;
                        case "L":
                        case "LOAD":
                            func.Load(ref done, ref showShort);
                            break;
                        case "EXIT":
                        case "E":
                            return true;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
