using System;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution
{
    public class Rectangle : Shape, IShapeComposition
    {

        private int _sideA ,_sideB;

        public Rectangle(int x, int y, int a, int b) : base(x, y)
        {
            _sideA = a;
            _sideB = b;
        }

        public double GetArea()
        {
            return _sideA * _sideB;
        }

        public double GetPerimeter()
        {
            return (2 *_sideA) + ( 2* _sideB);
        }

        public void PrintShapeType()
        {
            Console.WriteLine("I'm a Rectangle");
        }
    }
}
