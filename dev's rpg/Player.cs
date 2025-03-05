using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_s_rpg
{
    internal class Player
    {
        public void DrawPlayer()
        {
            int[,] currentLevelMap = Game.GetLevelMap();

            for (int i = 0; i < currentLevelMap.GetLength(0); i++)
            {
                for (int j = 0; j < currentLevelMap.GetLength(1); j++)
                {
                    if (currentLevelMap[i, j] == Level.PLAYER_HEAD)
                    {
                        Console.Write("O");
                        currentLevelMap[i + 1, j] = Level.PLAYER_BODY;
                        currentLevelMap[i + 1, j + 1] = Level.PLAYER_RARM;
                        currentLevelMap[i + 1, j - 1] = Level.PLAYER_LARM;
                        currentLevelMap[i + 2, j] = Level.PLAYER_FEET;
                    }
                }
            }
        }
    }
}
