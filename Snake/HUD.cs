using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HUD
    {
        public HUD()
        {
            PlayerNameFrame = new Rectangle(new Coordinate(1, 1), new Coordinate(20, 5), Symbol);
            GameTitleFrame = new Rectangle(new Coordinate(21, 1), new Coordinate(80, 5), Symbol);
            ScoreFrame = new Rectangle(new Coordinate(81, 1), new Coordinate(101, 5), Symbol);
            Init();
        }
        public HUD(string playerName) : this()
        {
            PlayerName = playerName;
            Init();
        }
        public HUD(string playerName, int score) : this (playerName)
        {
            Score = score;
        }

        char Symbol = '#';
        Rectangle PlayerNameFrame;
        Rectangle GameTitleFrame;
        Rectangle ScoreFrame;

        Coordinate PlayerNamePosition = new Coordinate(10,3);
        Coordinate GameTitlePosition = new Coordinate(40, 3);
        Coordinate ScorePosition = new Coordinate(84,3);

        string PlayerName;
        const string GameTitle = "SnakeGame by Jeremi Przeorek";
        int Score;
        
        public void ScoreRefresh()
        {
            Console.SetCursorPosition(ScorePosition.X, ScorePosition.Y);
            Console.Write(Score);
        }
        public void ScoreRefresh(int score)
        {
            Score = score;
            ScoreRefresh();
        }

        public void Init()
        {
            ScoreRefresh();
            Console.SetCursorPosition(GameTitlePosition.X, GameTitlePosition.Y);
            Console.Write(GameTitle);
            Console.SetCursorPosition(PlayerNamePosition.X, PlayerNamePosition.Y);
            Console.Write(PlayerName);
        }
    }
}
