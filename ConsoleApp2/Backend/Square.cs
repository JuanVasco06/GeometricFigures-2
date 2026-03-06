using System;

namespace GeometricFigures.Backend
{
    public class Square : GeometricFigure
    {
        private double _a;

        public double A
        {
            get => _a;
            set
            {
                ValidateA(value);
                _a = value;
            }
        }

        public Square(string name, double a) : base(name)
        {
            A = a;
        }

        public override double GetArea()
        {
            return Math.Pow(A, 2);
        }

        public override double GetPerimeter()
        {
            return 4 * A;
        }

        protected void ValidateA(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Side A must be greater than zero.");
        }
    }
}