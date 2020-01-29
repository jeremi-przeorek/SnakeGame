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
            TheGame theGame = new TheGame(1,1);
            //game loop
            while(!exit)
            {
                theGame.ChangeSnakesDirections();
                if((DateTime.Now - lastDate).TotalMilliseconds >= frameRate)
                {
                    theGame.MoveSnakes();
                    theGame.CheckIfSnakesAteSnack();
                    theGame.EndGameCheck();

                    lastDate = DateTime.Now;
                }
            }
        }
    }
}
