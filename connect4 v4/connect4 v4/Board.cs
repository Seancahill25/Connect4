using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connect4_v4
{
    public class Board
    {
        int height;
        int width;
    
        public Board()
        {
            this.height = 6;
            this.width = 7;
        }


        public void DrawBoard(State[,] board)
        {
            for(int row = 0; row <= this.height; row++)
            {
                for(int column = 0; column < this.width; column++)
                {
                    if(column < this.width)
                    {
                        Console.Write("+--+");
                    }
                }
                Console.WriteLine();
                for (int column = 0; column < this.width; column++)
                {
                    if (column < this.width)
                    {
                        Console.Write("|{0} |", board[row, column]);
                    }
                }
                Console.WriteLine(); 
            }
        }        
    }
}
