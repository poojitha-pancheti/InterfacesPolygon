﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon.Library
{
    public abstract class AbstractRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }
        public AbstractRegularPolygon(int sides,int length)
        {
            NumberOfSides = sides;
            SideLength = length;
        }
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
        public abstract double GetArea();
    }
}
