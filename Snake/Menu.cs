using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    static class Menu
    {
        public static string SelectedName = "";
        public static string ShowInitial()
        {
            bool exitMenu = false;
            Console.Clear();
            Banner banner = new Banner(new Coordinate(9, 5));
            Coordinate SlotsPosition = new Coordinate(25, 13);
            Slot play = new Slot("Play", SlotsPosition, "PlayerNameTyper");
            Slot highScore = new Slot("High Scores", SlotsPosition + new Coordinate(0, 2), "OpenHighScores");
            Slot exit = new Slot("Exit", SlotsPosition + new Coordinate(0, 4), "Exit");
            Slot[] slots = { play, highScore, exit };
            Rectangle border = new Rectangle(new Coordinate(1, 1), new Coordinate(59, 29), '#');
            Indicator indicator = new Indicator(SlotsPosition + new Coordinate(-2, 0), '>');

            string output = "";

            while (!exitMenu)
            {
                Coordinate upOffset = new Coordinate(0, 2);
                Coordinate downOffset = new Coordinate(0, -2);
                ConsoleKeyInfo input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (slots.Where(x => x.Position.Y.Equals(indicator.Position.Y - downOffset.Y)).ToList().Count > 0)
                        {
                            indicator.Move(new Coordinate(0, 2));
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (slots.Where(x => x.Position.Y.Equals(indicator.Position.Y + downOffset.Y)).ToList().Count > 0)
                        {
                            indicator.Move(new Coordinate(0, -2));
                        }
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
                Coordinate upOffset = new Coordinate(0, 2);
                Coordinate downOffset = new Coordinate(0, -2);
                ConsoleKeyInfo input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.DownArrow:
                        if (slots.Where(x => x.Position.Y.Equals(indicator.Position.Y - downOffset.Y)).ToList().Count > 0)
                        {
                            indicator.Move(new Coordinate(0, 2));
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (slots.Where(x => x.Position.Y.Equals(indicator.Position.Y + downOffset.Y)).ToList().Count > 0)
                        {
                            indicator.Move(new Coordinate(0, -2));
                        }
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

        public static string ShowPlayerNameTyper()
        {
            Console.Clear();
            Banner banner = new Banner(new Coordinate(9, 5));
            Rectangle border = new Rectangle(new Coordinate(1, 1), new Coordinate(59, 29), '#');
            Console.SetCursorPosition(20, 13);
            Console.Write("Type player name:");
            Console.SetCursorPosition(20, 14);
            do
            {
                Console.SetCursorPosition(20, 14);
                SelectedName = Console.ReadLine();
                if(SelectedName.Length >= 10)
                {
                    Console.SetCursorPosition(20, 13);
                    Console.Write("Player Name too long!");
                    Console.SetCursorPosition(20, 14);
                    Console.Write("                                       ");
                }
            } while (SelectedName.Length >= 10);
            string output = "PlayGame";
            return output;
        }
    }
}
