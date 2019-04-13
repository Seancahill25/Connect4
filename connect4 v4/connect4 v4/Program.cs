using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace connect4_v4
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectFourGame game = new ConnectFourGame();
            Board board = new Board();
            State[,] state = new State[6,7];
            while (ConnectFourGame.MovesCounter < 42)
            {
                game.DrawBoard(state);
                Console.WriteLine("Enter a column from 0-6");
                int column = Convert.ToInt32(Console.ReadLine());
                int row = Convert.ToInt32(Console.ReadLine());

                
                game.ApplyMove(column, row);
                game.DrawBoard(state);
               
                
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
