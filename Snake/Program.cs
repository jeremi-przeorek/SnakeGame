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
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();

                    switch(input.Key)
                    {
                        case ConsoleKey.Escape:
                            exit = true;
                            break;
                        case ConsoleKey.LeftArrow:
                            snake.CurrDirection = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            snake.CurrDirection = Direction.Right;
                            break;
                        case ConsoleKey.UpArrow:
                            snake.CurrDirection = Direction.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            snake.CurrDirection = Direction.Down;
                            break;
                    }
                }
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
