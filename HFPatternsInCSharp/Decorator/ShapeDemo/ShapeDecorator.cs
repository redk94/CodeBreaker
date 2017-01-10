using System;

namespace Decorator.ShapeDemo
{
    public abstract class ShapeDecorator : IShape
    {
        protected IShape DecoratedShape;

        protected ShapeDecorator(IShape decoragedShape)
        {
            this.DecoratedShape = decoragedShape;
        }

        public virtual void Draw()
        {
            DecoratedShape.Draw();
        }
    }
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
        {
        }

        public override void Draw()
        {
            base.Draw();
            SetRedBorder(DecoratedShape);
        }

        private void SetRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}