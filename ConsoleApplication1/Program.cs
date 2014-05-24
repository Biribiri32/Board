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
            DeckProgramFunctions func = new DeckProgramFunctions();

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
                        default:
                            break;
                    }
                }
            }
        }
    }
}
