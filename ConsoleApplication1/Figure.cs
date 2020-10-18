using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    abstract class Figure
    {
        public string Game { get; set; }
        public int Count { get; set; }
        public string Material { get; set; }

        public Figure(string game, int count, string material)
        {
            Game = game;
            Count = count;
            Material = material;
        }
    }
}
