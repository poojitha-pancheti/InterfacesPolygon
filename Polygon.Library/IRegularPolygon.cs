using System;
using System.Collections.Generic;
using System.Text;

namespace Polygon.Library
{
    public interface IRegularPolygon
    { 
        int NumberOfSides { get; set; }
        int SideLength { get; set; }
        double GetPerimeter();
        double GetArea();
    }
}
