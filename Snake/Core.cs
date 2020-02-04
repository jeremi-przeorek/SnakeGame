using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    static class Core
    {
        static public void Init()
        {
            Console.SetWindowSize(60, 30);
            Console.Clear();
            Console.CursorVisible = false;
            var nextMenu = Menu.ShowInitial();
            SelectMenu(nextMenu);
        }

        static public void SelectMenu(string nextMenu)
        {
            switch(nextMenu)
            {
                case "PlayGame":
                    PlayGame();
                    break;
                case "Exit":
                    throw new NotImplementedException();
                case "HighScores":
                    throw new NotImplementedException();

            }
        }
        static public void PlayGame()
        {
            Console.Clear();
            TheGame theGame = new TheGame(1, 1);
            HUD hud = new HUD("Jeremi", theGame.Snakes[0].Lenght);
            LimitBorder limitBorder = new LimitBorder(new Coordinate(1, 7), new Coordinate(59, 29), '@');

            double frameRate = 1000 / 25;
            DateTime lastDate = DateTime.Now;

            while (!theGame.Exit)
            {
                theGame.Snakes[0].ChangeDirection();
                if ((DateTime.Now - lastDate).TotalMilliseconds >= frameRate)
                {
                    theGame.Play();
                    hud.ScoreRefresh(theGame.Snakes[0].Lenght);
                    lastDate = DateTime.Now;
                }
            }
            Console.ReadLine();
        }
    }
}
