using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_s_rpg
{
    internal class Input
    {
        private static bool CheckInput(ConsoleKey key)
        {
            if (Console.ReadKey().Key == key)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
