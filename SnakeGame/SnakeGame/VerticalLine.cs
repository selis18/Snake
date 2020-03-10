using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yBot, int yTop, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yBot; y <= yTop; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
