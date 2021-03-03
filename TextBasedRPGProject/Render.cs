using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class Render
    {
        private Tile[,] backBuffer;
        int height;
        int width;

        public Render()
        {
            width = Console.WindowWidth;
            height = Console.WindowHeight - 1;
            backBuffer = new Tile[width, height];
        }
        public void Draw(Tile tile, Point2D position)
        {
            backBuffer[position.x, position.y] = tile;
        }
        public void Display()
        {
            Console.SetCursorPosition(0, 0);
            for(int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.ForegroundColor = backBuffer[x, y].fGColor;
                    Console.BackgroundColor = backBuffer[x, y].bGColor;
                    Console.Write(backBuffer[x, y].character);
                }
            }
        }


    }
}
