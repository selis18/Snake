using System;
using System.Collections.Generic;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(80, 25);

            HorizontalLine line = new HorizontalLine(5,10,8,'.');
            line.Draw();

            VerticalLine vLine = new VerticalLine(7, 15, 6, '+');
            vLine.Draw();

            Console.ReadLine();
            
        }

    }
}
