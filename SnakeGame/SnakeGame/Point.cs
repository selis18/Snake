﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public void Draw()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(sym);
        }
    }
}
