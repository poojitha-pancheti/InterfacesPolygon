using System;


namespace Polygon.Library
{
    public class Triangle:AbstractRegularPolygon
    {
        public Triangle(int length):
            base(3,length)
        { }
        public override double GetArea()
        {
            return SideLength;
        }
       
    }
}
