using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_s_rpg
{
    internal static class Game
    {
        private static Level debugLevel = new Level();

        //just here to debug the whole level thing
        public static void TestMethod()
        {
            debugLevel.LoadMap("debuglevel.map");
            debugLevel.RenderLevel();
        }

    }
}
