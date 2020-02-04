using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    static class Menu
    {
        public static string ShowInitial()
        {
            bool exitMenu = false;
            Console.Clear();
            Banner banner = new Banner(new Coordinate(9, 5));
            Coordinate SlotsPosition = new Coordinate(25, 13);
            Slot play = new Slot("Play", SlotsPosition, "PlayGame");
            Slot highScore = new Slot("High Scores", SlotsPosition + new Coordinate(0, 2), "OpenHighScores");
            Slot exit = new Slot("Exit", SlotsPosition + new Coordinate(0, 4), "Exit");
            Slot[] slots = { play, highScore, exit };
            Rectangle border = new Rectangle(new Coordinate(1, 1), new Coordinate(59, 29), '#');
            Indicator indicator = new Indicator(SlotsPosition + new Coordinate(-2, 0), '>');

            string output = "";

            while (!exitMenu)
            {
                ConsoleKeyInfo input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.DownArrow:
                        indicator.Move(0, 2);
                        break;
                    case ConsoleKey.UpArrow:
                        indicator.Move(0, -2);
                        break;
                    case ConsoleKey.Enter:
                        var selectedMenu = slots.Where(x => x.Position.Y.Equals(indicator.Position.Y)).ToArray();
                        output = selectedMenu[0].OpensMenu;
                        exitMenu = true;
                        break;
                }

            }
            return output;
        }
        public static string ShowAfterDeath()
        {
            bool exitMenu = false;
            Console.Clear();
            //Banner banner = new Banner(new Coordinate(9, 5));
            Coordinate SlotsPosition = new Coordinate(25, 13);
            Slot play = new Slot("Play again", SlotsPosition, "PlayGame");
            Slot highScore = new Slot("Main Menu", SlotsPosition + new Coordinate(0, 2), "Main Menu");
            Slot exit = new Slot("Exit", SlotsPosition + new Coordinate(0, 4), "Exit");
            Slot[] slots = { play, highScore, exit };
            Rectangle border = new Rectangle(new Coordinate(1, 1), new Coordinate(59, 29), '#');
            Indicator indicator = new Indicator(SlotsPosition + new Coordinate(-2, 0), '>');

            string output = "";

            while (!exitMenu)
            {
                int actualIndicatorPosition = slots.Length;
                ConsoleKeyInfo input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.DownArrow:
                        indicator.Move(0, 2);
                        actualIndicatorPosition--;
                        break;
                    case ConsoleKey.UpArrow:
                        indicator.Move(0, -2);
                        actualIndicatorPosition--;
                        break;
                    case ConsoleKey.Enter:
                        var selectedMenu = slots.Where(x => x.Position.Y.Equals(indicator.Position.Y)).ToArray();
                        output = selectedMenu[0].OpensMenu;
                        exitMenu = true;
                        break;
                }
            }
            return output;
        }
    }
}
