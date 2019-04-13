using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connect4_v4
{
    public class ConnectFourGame : Board
    {        
        public static int MovesCounter { get; private set; }
        public State[,] _board = new State[6, 7];

        public ConnectFourGame()
        {

            for (int row = 0; row < _board.GetLength(0); row++)
            {
                for (int column = 0; column < _board.GetLength(1); column++)
                {
                    _board[row, column] = State._;
                }
            }
        }

        public void ApplyMove(int column, int row)
        {
            State state = MovesCounter % 2 == 0 ? State.X : State.O;
            
                if (_board[row, column] < 0)
                {
                    Console.WriteLine("You can only choose a column from 0-6");
                    
                }

                if (_board[0, column] != State._)
                {
                    Console.WriteLine("Oops!This spot is already taken!");    
                }

                else
                {
                    _board[row, column] = state;
                    Console.WriteLine($"{_board[row, column]} you moved to {column}");
                    MovesCounter++;
                }   
        }
    }
}
