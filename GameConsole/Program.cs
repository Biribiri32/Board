using ClassManager.ClassComponents;
using GameConsole.ConsoleComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogic logic = new ConsoleLogic();

            logic.RunConsole();
        }
    }
}
