﻿using Polygon.Library;
using System;

namespace Polygon
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Sqaure(9);
            DisplayPolygon("Square", square);
            //var triangle = new Triangle(6);
            //DisplayPolygon("Triangle", triangle);
            Console.Read();
        }
        public static void DisplayPolygon(string polygonType,dynamic polygon)
        {
            try
            {
                Console.WriteLine($"{polygonType} Number of Sides: {polygon.NumberOfSides}");
                Console.WriteLine($"{polygonType} Side Length: {polygon.SideLength}");
                Console.WriteLine($"{polygonType} Perimeter: {polygon.GetPerimeter()}");
                Console.WriteLine($"{polygonType} Area: {Math.Round(polygon.GetArea(), 2)}");
                Console.WriteLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"Exception was thrown while trying to process {polygonType}:\n   {ex.GetType().Name}");
                Console.WriteLine();
            }
        }
    }
}
