using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Block
    {
        public Block(int x, int y)
        {
            coordinate.X = x;
            coordinate.Y = y;
            PaintSymbol();
        }
        public Block(int x, int y, char symbol) : this(x, y)
        {
            BlockSymbol = symbol;
            PaintSymbol();
        }
        public Coordinate coordinate = new Coordinate();
        char BlockSymbol = '|';

        public void PaintSymbol()
        {
            Console.SetCursorPosition(coordinate.X, coordinate.Y);
            Console.Write(BlockSymbol);
        }
    }
}
