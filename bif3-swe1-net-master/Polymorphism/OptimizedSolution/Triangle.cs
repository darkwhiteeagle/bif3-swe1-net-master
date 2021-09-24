using System;

namespace Bif3.Swe1.Oop.Polymorphism.OptimizedSolution
{
    public class Triangle : Shape, IShapeComposition
    {

        private int _sideA,_sideB,_sideC,_height;

        public Triangle(int x, int y, int a, int b, int c ,int h) : base(x, y)
        {
            _sideA = a;
            _sideB = b;
            _sideC = c;
            _height = h;
        }

        public double GetArea()
        {
            int g= Math.Max(Math.Max(_sideA, _sideB), _sideC);  //Grundseite berechnen

            return (1/2) * g * _height;
        }

        public double GetPerimeter()
        {
            return _sideA + _sideB + _sideC;
        }

        public void PrintShapeType()
        {
            Console.WriteLine("I'm a Triangle");
        }
    }
}
