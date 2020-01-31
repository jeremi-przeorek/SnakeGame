using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class TheGame
    {
        public TheGame (int numberOfPlayers, int numberOfSnacks)
        {
            NumberOfPlayers = numberOfPlayers;
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Snakes.Add(new Snake(20 * i, 40,i));
            }
            for (int i = 0; i < numberOfSnacks; i++)
            {
                Snacks.Add(new Snack());
            }
        }
        public List<Snake> Snakes { get; set; } = new List<Snake>();
        public List<Snack> Snacks { get; set; } = new List<Snack>();
        public int NumberOfPlayers { get; set; }

        public void EndGameCheck()
        {
            if (Snakes.Where(x => x.GameOver == true).ToList().Count > 0)
            {
                Console.Clear();
                Console.SetCursorPosition(20, 10);
                Console.WriteLine($"GAME OVER. YOUR SCORE = ");
                //exit = true;
                Console.ReadLine();
            }
        }
        public void ChangeSnakesDirections()
        {
            foreach(Snake snake in Snakes)
            {
                snake.ChangeDirection();
            }
        }
        public void MoveSnakes()
        {
            foreach (Snake snake in Snakes)
            {
                snake.Move();
            }
        }
        public void CheckIfSnakesAteSnack()
        {
            foreach(Snake snake in Snakes)
            {
                for (int i = 0; i < Snacks.Count; i++)
                {
                    if (snake.HeadCoordinate.Equals(Snacks[i].CurrentTarget))
                    {
                        snake.EatSnack();
                        Snacks[i] = new Snack(); 
                        while (Snacks[i].IsInSnake(snake))
                        {
                            Snacks[i].Erase();
                            Snacks[i] = new Snack();
                        }
                    }
                }

            }
        }
        public void Play()
        {
                double frameRate = 1000 / 500;
                DateTime lastDate = DateTime.Now;
                if ((DateTime.Now - lastDate).TotalMilliseconds >= frameRate)
                {
                    MoveSnakes();
                    //theGame.CheckIfSnakesAteSnack();
                    //theGame.EndGameCheck();

                    lastDate = DateTime.Now;
                }
        }
    }
}
