using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class Map
    {
        private char[,] map;
        public Map()
        {
            LoadMap();
        }
        private void LoadMap()
        {

            string[] lines = System.IO.File.ReadAllLines("map.txt");
            map = new char[lines[0].Length, lines.Length];
            for (int y = 0; y < lines.Length; y++)
            {
                string line = lines[y];
                for (int x = 0; x < line.Length; x++)
                {
                    map[x, y] = line[x];
                }
            }

        }
        public void Update()
        {

        }
        public void Draw()
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
