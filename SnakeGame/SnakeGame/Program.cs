﻿using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(4,6,'$');
            p2.Draw();

            Console.ReadLine();
            
        }

    }
}
