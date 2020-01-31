using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Rectangle
    {
        public Rectangle(Coordinate leftUpCorner, Coordinate rightDownCorner, char symbol)
        {
            Coordinate leftDownCorner = new Coordinate(leftUpCorner.X, rightDownCorner.Y);
            Coordinate rightUpCorner = new Coordinate(rightDownCorner.X, leftUpCorner.Y);

            Walls[0] = new Wall(leftUpCorner, rightUpCorner, symbol);
            Walls[1] = new Wall(leftUpCorner, leftDownCorner, symbol);
            Walls[2] = new Wall(rightUpCorner, rightDownCorner, symbol);
            Walls[3] = new Wall(leftDownCorner, rightDownCorner, symbol);
        }

        Wall[] Walls = new Wall[4];
    }
}
