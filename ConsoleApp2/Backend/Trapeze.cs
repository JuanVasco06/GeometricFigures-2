using System;

namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        private double _d;

        public double D
        {
            get => _d;
            set
            {
                ValidateD(value);
                _d = value;
            }
        }

        public Trapeze(string name, double a, double b, double c, double d, double h)
            : base(name, a, b, c, h)
        {
            D = d;
        }

        public override double GetArea()
        {
            return ((B + D) * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C + D;
        }

        private void ValidateD(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Side D must be greater than zero.");
        }
    }
}