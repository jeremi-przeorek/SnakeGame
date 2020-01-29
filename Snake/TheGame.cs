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
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Snakes.Add(new Snake(5 * i, 1));
            }
            for (int i = 0; i < numberOfSnacks; i++)
            {
                Snacks.Add(new Snack());
            }
        }
        public List<Snake> Snakes { get; set; }
        public List<Snack> Snacks { get; set; }
    }
}
