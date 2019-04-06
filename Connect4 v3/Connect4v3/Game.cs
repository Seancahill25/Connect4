using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawBoardV2Milo
{
    public class Game
    {
        public char[,] GameMoves(int height , int width)
        {
            char[,] moves = new char[height, width];
            return moves;
        }
       
        public void DropPiece(char[,] moves)
        {
            Console.WriteLine("Please enter a number between 1 and 7: ");
            int dropChoice = Convert.ToInt32(Console.ReadLine());
            int height = 4;

            if(moves[height, dropChoice] != 'X')
            {
                moves[height, dropChoice] = 'X';
            }

        }
    }
}
