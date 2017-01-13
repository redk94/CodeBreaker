using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class LiskovSubstitutionPrinciple
    {
        public void ShowDemo()
        {
            var myRectangle = new Rectangle { Height = 2, Width = 3 };
            var result = AreaCalculator.CalculateArea(myRectangle);
            Assert.AreEqual(6, result);

            var mySquare = new Square { Height = 3 };
            result = AreaCalculator.CalculateArea(mySquare);
            Assert.AreEqual(9, result);

            Rectangle newRectangle = new Square();
            newRectangle.Height = 4;
            newRectangle.Width = 6;
            result = AreaCalculator.CalculateArea(newRectangle);
            Assert.AreEqual(24, result);
        }

        private class Rectangle
        {
            public virtual int Height { get; set; }
            public virtual int Width { get; set; }
        }

        private class Square : Rectangle
        {
            private int _height;
            private int _width;
            public override int Height
            {
                get
                {
                    return _height;
                }
                set
                {
                    _height = value;
                    _width = value;
                }
            }
            public override int Width
            {
                get
                {
                    return _width;
                }
                set
                {
                    _width = value;
                    _height = value;
                }
            }

        }

        private class AreaCalculator
        {
            public static int CalculateArea(Rectangle r)
            {
                return r.Height * r.Width;
            }

            public static int CalculateArea(Square s)
            {
                return s.Height * s.Height;
            }
        }
    }

    public class LiskovSubstitutionPrincipleSolution
    {
        public void ShowDemo()
        {
            var shapes = new List<Shape>{
                new Rectangle{Height=4,Width=6},
                new Square{Sides=3}
            };
            var areas = new List<int>();


            foreach (Shape shape in shapes)
            {
                areas.Add(shape.GetArea());
            }
            Assert.AreEqual(24, areas[0]);
            Assert.AreEqual(9, areas[1]);
        }


        public abstract class Shape
        {
            public abstract int GetArea();
        }
        
        private class Rectangle : Shape
        {
            public int Height { get; set; }
            public int Width { get; set; }

            public override int GetArea()
            {
                return Height * Width;
            }
        }

        private class Square : Shape
        {
            public int Sides { get; set; }

            public override int GetArea()
            {
                return Sides * Sides;
            }
        }
    }
}
