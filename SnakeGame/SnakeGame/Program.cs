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

            FoodCreater foodCreater = new FoodCreater(80, 25, '$');
            Point food = foodCreater.CreateFood();
            food.Draw();

            //движение змейки
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreater.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(150);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handlekey(key.Key);
                }
                
            }
           
            
        }

    }
}
