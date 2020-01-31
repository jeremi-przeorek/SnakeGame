using System;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool exit = false;

            TheGame theGame = new TheGame(1, 1);
            HUD hud = new HUD("Jeremi", theGame.Snakes[0].Lenght);

            double frameRate = 1000 / 20;
            DateTime lastDate = DateTime.Now;

            while (true)
            {
                theGame.Snakes[0].ChangeDirection();
                if ((DateTime.Now - lastDate).TotalMilliseconds >= frameRate)
                {
                    theGame.Play();
                    hud.ScoreRefresh(theGame.Snakes[0].Lenght);
                    lastDate = DateTime.Now;
                }
            }
        }
    }
}
