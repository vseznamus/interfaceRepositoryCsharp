using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class Queen : Figure, IMovable
    {

        public int Age { get; set; }

        public Queen(string game, int count, string material, int age)
            : base(game, count, material)
        {
            Age = age;
        }

        public void Move()
        {
            Console.WriteLine("Figure queen didnt move");
        }
    }
}
