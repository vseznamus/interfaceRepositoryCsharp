using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class Knight : Figure, IMovable
    {
        public int Age { get; set; }

        public Knight(string game, int count, string material, int age)
            : base(game, count, material)
        {
            Age = age;
        }

        public void Move()
        {
            Console.WriteLine("Figure knight has been moved diagonal");
        }
    }
}
