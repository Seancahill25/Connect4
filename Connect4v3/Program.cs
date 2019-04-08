using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            game game = new game();

            Console.WriteLine("select amount of rows");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("select amount of columns");
            int columns = Convert.ToInt32(Console.ReadLine());

            game.GameMoves(rows, columns);
            board.BuildBoard(rows, columns);
        }
    }
}
