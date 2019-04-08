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
            Console.WriteLine("Enter height of board between 2 and 30: ");
            int height = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter width of board between 2 and 30");
            int width = Convert.ToInt32(Console.ReadLine());


            if (height < 2 || height > 30)
            {
                Console.WriteLine("Please enter a valid height");
            }
            if (width < 2 || width > 30)
            {
                Console.WriteLine("Please enter a valid width");
            }

            GameBoard myGame = new GameBoard(height, width);
            Game moves = new Game();
            char[,] board = moves.GameMoves(height, width);
            myGame.DrawBoard(height, width);
            moves.DropPiece(board);
            myGame.DrawBoard(height, width);
        }
    }
}
