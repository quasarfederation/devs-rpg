namespace dev_s_rpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game rpgGame = new Game(1);
            rpgGame.GameLoop();
        }
    }
}
