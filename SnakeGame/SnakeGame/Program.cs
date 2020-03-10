using System;
using System.Collections.Generic;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            //отрисовка рамки
            HorizontalLine upLine = new HorizontalLine(0,78,0,'.');
            upLine.Draw();
            HorizontalLine dLine = new HorizontalLine(0, 78, 24, '.');
            dLine.Draw();
            VerticalLine lLine = new VerticalLine(0, 24, 0, '.');
            lLine.Draw();
            VerticalLine rLine = new VerticalLine(0, 24, 78, '.');
            rLine.Draw();

            Console.ReadLine();
            
        }

    }
}
