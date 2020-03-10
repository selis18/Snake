using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class FoodCreater
    {
        int mapWidth;
        int mapHeight;
        char sym;

        Random rand = new Random();

        public FoodCreater(int mapWidth, int mapHeight, char sym)
        {
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = rand.Next(2, mapWidth - 2);
            int y = rand.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }

    }
}
