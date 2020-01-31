using System;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool exit = false;
            
            TheGame theGame = new TheGame(2,1);

            Task player1Game = new Task(theGame.Snakes[0].ChangeDirection);
            player1Game.Start();
            Task player2Game = new Task(theGame.Snakes[1].ChangeDirection);
            player2Game.Start();

            while(true)
            {
                theGame.Play();
            }
        }
    }
}
