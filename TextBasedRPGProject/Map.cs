using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class Map
    {
    

        private Tile[,] map;

        //private char[,] map;
        public Map()
        {
            LoadMap();
        }
        private void LoadMap()
        {

            string[] lines = System.IO.File.ReadAllLines("map.txt");
            map = new Tile[lines[0].Length, lines.Length];
            for (int y = 0; y < lines.Length; y++)
            {
                string line = lines[y];
                for (int x = 0; x < line.Length; x++)
                {
                    char ch = line[x];

                    map[x, y].character = ch;
                    map[x, y].fGColor = ConsoleColor.White;
                    map[x, y].bGColor = ConsoleColor.Black;
                    if(ch == '^')
                    {
                        map[x, y].fGColor = ConsoleColor.Gray;
                        map[x, y].bGColor = ConsoleColor.Black;
                    }
                    if (ch == '~')
                    {
                        map[x, y].fGColor = ConsoleColor.Yellow;
                        map[x, y].bGColor = ConsoleColor.Black;
                    }
                    if (ch == '#')
                    {
                        map[x, y].fGColor = ConsoleColor.DarkBlue;
                        map[x, y].bGColor = ConsoleColor.Black;
                    }
                }
            }

        }
        public bool IsWall(int x, int y)
        {
            if (map[x, y].character == '#') 
                return true;
            else 
                return false;
        }
        public void Update()
        {

        }
        public void Draw(Render render)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Coord2D temp;
                    temp.x = x;
                    temp.y = y;
                    render.Draw(map[x, y], temp);
                }
            }
        }
    }
}
