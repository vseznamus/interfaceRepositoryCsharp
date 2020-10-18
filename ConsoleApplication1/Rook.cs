using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class Rook : Figure, IMovable
    {
        public int Age { get; set; }

        public Rook(string game, int count, string material, int age)
            : base(game, count, material)
        {
            Age = age;
        }

        public void Move()
        {
            Console.WriteLine("Figure rook has been killed");
        }
    }
}
