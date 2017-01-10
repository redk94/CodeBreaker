using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ShapeDemo
{
    public interface IShape
    {
        void Draw();
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
