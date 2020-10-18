using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class King : Figure, IMovable
    {
        public int Age { get; set; }

        public King(string game, int count, string material, int age)
            : base(game, count, material)
        {
            Age = age;
        }

        public void Move()
        {
            Console.WriteLine("Figure king has been moved as you point");
        }
    }
}
