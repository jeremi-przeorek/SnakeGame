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

            Task player1Game = new Task(theGame.StartGamePlayer1);
            player1Game.Start();
            Task player2Game = new Task(theGame.StartGamePlayer2);
            player2Game.Start();

            Task.WaitAll(player1Game, player2Game);
        }
    }
}
