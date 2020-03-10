﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
