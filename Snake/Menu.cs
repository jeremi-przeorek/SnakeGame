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
            Slot play = new Slot("Play", new Coordinate(10, 10),"PlayGame");
            Slot highScore = new Slot("High Scores", new Coordinate(10, 12),"OpenHighScores");
            Slot exit = new Slot("Exit", new Coordinate(10, 14), "ExitGame");
            Slot[] slots = { play, highScore, exit };
            Block indicator = new Block(8, 10, '>');

            string output = "";
            
            while (!exitMenu)
            {
                ConsoleKeyInfo input = Console.ReadKey(true);
                switch (input.Key)
                {
                    case ConsoleKey.DownArrow:
                        indicator.Move(0,2);
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
        static Coordinate Position;
        static char SelectSymbol = '>';
    }
}
