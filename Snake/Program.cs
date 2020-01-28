using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            double frameRate = 1000 / 5.0;
            DateTime lastDate = DateTime.Now;
            Snack snack = new Snack();
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
                            //x
                            break;
                        case ConsoleKey.RightArrow:
                            //x
                            break;
                        case ConsoleKey.UpArrow:
                            //x
                            break;
                        case ConsoleKey.DownArrow:
                            //x
                            break;
                    }
                }
                if((DateTime.Now - lastDate).TotalMilliseconds >= frameRate)
                {
                    //game action
                    lastDate = DateTime.Now;
                }
            }
        }
    }
}
