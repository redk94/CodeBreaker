using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ShapeDemo
{
    public class DecoratorPatternDemo
    {
        public void ShowDemo()
        {
            //create 
            IShape circle = new Circle();
            IShape rectangle = new Rectangle();

            //decorate
            IShape redCircle = new RedShapeDecorator(circle);
            IShape redRectangle = new RedShapeDecorator(rectangle);


            Console.WriteLine("Circle with normal boarder");
            circle.Draw();

            Console.WriteLine("Circle with red boarder");
            redCircle.Draw();

            Console.WriteLine("Rectangle with normal boarder");
            rectangle.Draw();

            Console.WriteLine("Rectangle with red boarder");
            redRectangle.Draw();
        }
    }
}