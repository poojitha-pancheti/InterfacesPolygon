using System;


namespace Polygon.Library
{
    public class Octagon:Object,IRegularPolygon
    {
        public int NumberOfSides { get; set; }
        public int SideLength { get; set; }
        public Octagon(int Length)
        {
            NumberOfSides = 8;
            SideLength = Length;
        }
        public double GetPerimeter()
        {
            return NumberOfSides * SideLength;
        }
        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2)); 
        }
    }
}
