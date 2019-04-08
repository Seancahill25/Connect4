using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{

    public class GameBoard
    {
        int height;
        int width;

        public GameBoard(int h, int w)
        {
            this.height = h;
            this.width = w;
        }

        private void drawTop()
        {
            Console.Write(" __ ");
        }

        private void drawWalls()
        {
            Console.Write("|  |");
        }

        private void drawBottom()
        {
            Console.Write(" -- ");
        }

        public void DrawBoard(int height, int width, char[,] moves)
        {
            for (int rowCounter = 0; rowCounter < height; rowCounter++)
            {
                for (int columnCounter = 0; columnCounter < width; columnCounter++)
                {
                    drawTop();
                }
                Console.WriteLine();
                for (int wallCounter = 0; wallCounter < width; wallCounter++)
                {
                    drawWalls();
                }
                Console.WriteLine();

                for (int bottomCounter = 0; bottomCounter < width; bottomCounter++)
                {
                    drawBottom();
                }
                Console.WriteLine();
            }
        }
    }
}
