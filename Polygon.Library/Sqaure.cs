using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon.Library
{
    public class Sqaure:ConcreteRegularPolygon
    {
        public Sqaure(int length):
            base(4,length)
        { }
        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}
