using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_s_rpg
{
    internal static class Game
    {
        private static Level currentLevel = new Level();

        //just here to debug the whole level thing
        public static void TestMethod()
        {
            currentLevel.LoadMap("debuglevel.map");
            Player player = new Player();
            player.DrawPlayer();
            currentLevel.RenderLevel();
        }

        public static int[,] GetLevelMap()
        {
            return currentLevel.levelMap;
        }

    }
}
