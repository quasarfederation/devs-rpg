using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_s_rpg
{
    internal class Level
    {
        // These are ascii codes, not the actual number
        private const int EMPTY_SPACE = 48;
        private const int SIDE_BARRIER = 49;
        private const int VERT_BARRIER = 50;

        public static readonly int PLAYER_HEAD = 51;
        public static readonly int PLAYER_BODY = 52;
        public static readonly int PLAYER_FEET = 53;
        public static readonly int PLAYER_LARM = 54;
        public static readonly int PLAYER_RARM = 55;


        private const int LEVELMAPHEIGHT = 20;
        private const int LEVELMAPWIDTH = 120;


        public int[,] levelMap = new int[LEVELMAPHEIGHT, LEVELMAPWIDTH];

        public void RenderLevel()
        {
            for (int i = 0; i < LEVELMAPHEIGHT; i++)
            {
                for (int j = 0; j < LEVELMAPWIDTH; j++)
                {
                    switch (levelMap[i, j])
                    {
                        case EMPTY_SPACE:
                            Console.Write(" "); 
                            break;
                        case SIDE_BARRIER:
                            Console.Write("|");
                            break;
                        case VERT_BARRIER:
                            Console.Write("-");
                            break;
                        case 52:
                            Console.Write("|");
                            break;
                        case 53:
                            Console.Write("^");
                            break;
                        case 54:
                            Console.Write("/");
                            break;
                        case 55:
                            Console.Write("\\");
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
        }

        public void LoadMap(string mapFile)
        {
            using (StreamReader saveReader = new StreamReader(@"maps\" + mapFile))
            {
                for (int i = 0; i < LEVELMAPHEIGHT; i++)
                {
                    for (int j = 0; j < LEVELMAPWIDTH; j++)
                    {
                        levelMap[i, j] = saveReader.Read();
                    }
                    saveReader.ReadLine();
                }
            }
        }

    }
}
