using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool exit = false;
            double frameRate = 1000 / 20.0;
            DateTime lastDate = DateTime.Now;
            Snack snack = new Snack();
            Snake snake = new Snake();
            //game loop
            while(!exit)
            {
                snake.ChangeDirection();
                if((DateTime.Now - lastDate).TotalMilliseconds >= frameRate)
                {
                    snake.Move();

                    if(snake.GameOver)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(20, 10);
                        Console.WriteLine($"GAME OVER. YOUR SCORE = {snake.Lenght}");
                        exit = true;
                        Console.ReadLine();
                    }

                    if(snake.HeadCoordinate.Equals(snack.CurrentTarget))
                    {
                        snake.EatSnack();
                        snack = new Snack();
                        while(snack.IsInSnake(snake))
                        {
                            snack.Erase();
                            snack = new Snack();
                        }
                    }

                    lastDate = DateTime.Now;
                }
            }
        }
    }
}
