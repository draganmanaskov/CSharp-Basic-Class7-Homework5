using System;
using System.Collections.Generic;
using System.Text;

using ShapesLibrary.Enums;


namespace ShapesLibrary.Models
{
    public class Shape
    {
        private string _name;

        private ValidColorsEnum _color;

        public Shape(string name, ValidColorsEnum color, int[] position)
        {
            Name = name;
            Color = color;
            Position = position;
        }

        public string Name
        {
            get
            {
                Console.WriteLine($"Get Name: {_name}");
                return _name;
            }
            set
            {
                Console.WriteLine($"Setting Name: {value}");

                if (String.IsNullOrEmpty(value))
                {
                    _name = "DefaultName";
                }  
                // trims empty space and makes first letter capital
                else
                {
                    string temp = value.Trim();
                    _name = Char.ToUpper(temp[0]) + temp.Substring(1);
                }
                    
            }
        }

        public ValidColorsEnum Color
        { 
            get
            {
                Console.WriteLine($"Get Color: {_color}");
                return _color;
            } 
            set
            {
                Console.WriteLine($"Setting Color: {value}");

                //if the color is default , set a random color
                if (value == ValidColorsEnum.Default)
                {
                    Random rnd = new Random();

                    int myEnumMemberCount = Enum.GetNames(typeof(ValidColorsEnum)).Length;

                    int randomColor = rnd.Next(1, myEnumMemberCount);

                    _color = (ValidColorsEnum)randomColor;
                }
                else
                {
                    _color = value;
                }         
            } 
        }


        public int[] Position { get; set; }

        public virtual void getArea()
        {
            Console.WriteLine("There is no special implementation for area");
        }

        public virtual void getPerimeter()
        {
            Console.WriteLine("There is no special implementation for perimeter");
        }

        public static void Move(Shape shapeObject)
        {
            shapeObject.Position[0] += 5;
            shapeObject.Position[1] += 5;
            Console.WriteLine($"New position: X: { shapeObject.Position[0]}, Y: {shapeObject.Position[1]}");
        }
    }
}
