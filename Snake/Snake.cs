﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Snake : ISnake
    {
        public int Lenght { get; set; } = 5;
        public Direction CurrDirection { get; set; } = Direction.Right;
        public Coordinate HeadCoordinate { get; set; } = new Coordinate();
        List<Coordinate> Tail { get; set; } = new List<Coordinate>();
        private bool outOfRange = false;
        public bool GameOver
        {
            get { return Tail.Where(c => c.X == HeadCoordinate.X && c.Y == HeadCoordinate.Y).ToList().Count > 1 || outOfRange; }
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
                    HeadCoordinate.Y--;
                    break;
                case Direction.Down:
                    HeadCoordinate.Y++;
                    break;
            }
            try
            {
                Console.SetCursorPosition(HeadCoordinate.X, HeadCoordinate.Y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("@");
                Tail.Add(new Coordinate(HeadCoordinate.X, HeadCoordinate.Y));
                if(Tail.Count > this.Lenght)
                {
                    var endTail = Tail.First();
                    Console.SetCursorPosition(endTail.X, endTail.Y);
                    Console.Write(" ");
                    Tail.Remove(endTail);
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                outOfRange = true;
            }
        }
    }
    public enum Direction { Left,Right,Up,Down}
}
