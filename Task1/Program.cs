using System;

using ShapesLibrary.Models;

using ShapesLibrary.Enums;


namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Shape test = new Shape(" triangle", ValidColorsEnum.Red, new int[] {5, 12});
            //Shape test1 = new Shape("", ValidColorsEnum.Default, new int[] {4, 10});

            //Console.WriteLine(test.Color);
            //Console.WriteLine(test.Name);

            //Console.WriteLine(test1.Color);
            //Console.WriteLine(test1.Name);

            Rectangle rectangleOne = new Rectangle(" rectangleOne", ValidColorsEnum.Orange, new int[] {1, 30}, 2,3);

            Rectangle.Move(rectangleOne);
            rectangleOne.getArea();
            rectangleOne.getPerimeter();


            Console.WriteLine("--------------");
            Circle circleOne = new Circle("CircleOne", ValidColorsEnum.Default, new int[] { 23, 10 }, 5);

            Circle.Move(circleOne);
            circleOne.getArea();
            circleOne.getPerimeter();
        }
    }
}
