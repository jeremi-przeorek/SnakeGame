using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Indicator : Block
    {
        public Indicator(Coordinate position, char symbol) : base(position, symbol) { }
        public void Move(int offsetX, int offsetY)
        {
            base.Erase();
            base.Position.X += offsetX;
            base.Position.Y += offsetY;
            base.Paint();
            Console.Beep(1000, 20);
        }
    }
}
