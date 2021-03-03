using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class Render
    {
        private Tile[,] backBufferCurr;
        private Tile[,] backBufferPrev;
        int height;
        int width;

        public Render()
        {
            width = Console.WindowWidth;
            height = Console.WindowHeight - 1;
            backBufferCurr = new Tile[width, height];
            backBufferPrev = new Tile[width, height];
        }
        public void Draw(Tile tile, Point2D position)
        {
            backBufferCurr[position.x, position.y] = tile;
        }
        public void Display()
        {
          
            for(int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (!Equals(backBufferCurr[x, y], backBufferPrev[x, y]))
                    {
                        Console.SetCursorPosition(x, y);
                        Console.ForegroundColor = backBufferCurr[x, y].fGColor;
                        Console.BackgroundColor = backBufferCurr[x, y].bGColor;
                        Console.Write(backBufferCurr[x, y].character);

                        backBufferPrev[x, y] = backBufferCurr[x, y];
                    }
                }
            }
        }


    }
}
