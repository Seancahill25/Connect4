using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    class Board
    {
        public char[,] GameMoves(int height, int width)
        {
            char[,] moves = new char[height, width];
            return moves;
        }

        static String[] parts = { "|", " ", "+", "-" };
        String wall = parts[0];
        String space = parts[1];
        String plus = parts[2];
        String dash = parts[3];

        public void BuildBoard(int height, int width)
        {
            for (var vert = 0; vert <= height * 2; vert++)
            {
                for (var horz = 0; horz <= width; horz++)
                {
                    if (vert % 2 == 0)
                    {
                        Console.Write("{0}{1}", plus, dash);
                        if (horz == width - 1)
                        {
                            Console.Write("{0}{1}", plus, space);
                            break;
                        }
                    }
                    else
                    {
                        Console.Write("{0}{1}", wall, space);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
