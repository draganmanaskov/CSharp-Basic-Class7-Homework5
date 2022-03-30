using ShapesLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary.Models
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        private double _pi = 3.14;

        public Circle(string name, ValidColorsEnum color, int[] position, int radius) : base(name, color, position)
        {
            Radius = radius;
        }

        public override void getArea()
        {
            Console.WriteLine("The are of this circle is: {0:0.00}", _pi * Radius * Radius);
        }

        public override void getPerimeter()
        {
            Console.WriteLine("The perimeter of this circle is: {0:0.00}",  _pi * Radius *2);
        }
    }
}
