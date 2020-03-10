using System;
using System.Collections.Generic;
using System.Threading;

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

            //создание змейки
            Point p = new Point(4, 5,'+');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
           

            Console.ReadLine();
            
        }

    }
}
