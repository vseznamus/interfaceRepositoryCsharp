using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class Pawn : Figure, IMovable
    {
        public int Age { get; set; }

        public Pawn(string game, int count, string material, int age)
            : base(game, count, material)
        {
            Age = age;
        }

        public void Move()
        {
            Console.WriteLine("Figure pawn has been moved forward to 2 cells");
        }
    }
}
