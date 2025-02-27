using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_s_rpg
{
    internal class Game
    {
        private List<Level> levels = new List<Level>();
        private Level DebugLevel = new Level();
        private float globalDifficulty;
        public bool stopGame = false;
        private ConsoleKey input;

        public Game(float _globalDifficulty)
        {
            globalDifficulty = _globalDifficulty;
        }

        public void GameLoop()
        {
            while (!stopGame)
            {
                DebugLevel.RenderLevel();
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
