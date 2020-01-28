using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake : ISnake
    {
        public int Lenght { get; set; } = 1;
        public Direction CurrDirection { get; set; } = Direction.Right;
        public Coordinate HeadCoordinate { get; set; } = new Coordinate();
        List<Coordinate> Tail { get; set; } = new List<Coordinate>();
        private bool outOfRange = false;
        public bool GameOver
        {
            get { return Tail.Where(c => c.X == HeadCoordinate.X && c.Y == HeadCoordinate.Y).ToList().Count > 1; }
        }
        public void EatSnack()
        {
            Lenght++;
        }

        public void Move()
        {
            switch(CurrDirection)
            {
                case Direction.Left:
                    HeadCoordinate.X--;
                    break;
                case Direction.Right:
                    HeadCoordinate.X++;
                    break;
                case Direction.Up:
                    HeadCoordinate.Y++;
                    break;
                case Direction.Down:
                    HeadCoordinate.Y--;
                    break;
            }
            try
            {
                Console.SetCursorPosition(HeadCoordinate.X, HeadCoordinate.Y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("@");
            }
            catch(ArgumentOutOfRangeException)
            {
                outOfRange = true;
            }
        }
    }
    public enum Direction { Left,Right,Up,Down}
}
