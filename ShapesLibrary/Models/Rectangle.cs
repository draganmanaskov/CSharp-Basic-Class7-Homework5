using ShapesLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesLibrary.Models
{
    public class Rectangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }

        public Rectangle(string name, ValidColorsEnum color, int[] position, int sideA, int sideB) : base(name, color, position)
        {
            SideA = sideA;

            SideB = sideB;
        }

        public override void getArea()
        {
            Console.WriteLine($"The are of this rectangle is: {SideA * SideB}");
        }

        public override void getPerimeter()
        {
            Console.WriteLine($"The perimeter of this rectangle is: {(SideA + SideB) * 2}");
           
        }
    }
}
