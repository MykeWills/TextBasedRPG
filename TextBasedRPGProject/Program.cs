﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedRPGProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            GameManager gameManager = new GameManager();


            gameManager.RunGame();
            
            Console.ReadKey(true);

        }
    }
}
