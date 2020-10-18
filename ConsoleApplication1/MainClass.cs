using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Bishop chessBishop = new Bishop("Chess",50,"wood", 100);
            chessBishop.Move();
            King chessKing = new King("Chess", 3, "iron", 10);
            chessKing.Move();
            Knight chessKnight = new Knight("Chess", 2, "keramick", 1);
            chessKnight.Move();
        }
    }
}
