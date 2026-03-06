using System;

namespace GeometricFigures.Backend
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;

        public double C
        {
            get => _c;
            set
            {
                ValidateC(value);
                _c = value;
            }
        }

        public double H
        {
            get => _h;
            set
            {
                ValidateH(value);
                _h = value;
            }
        }

        public Triangle(string name, double a, double b, double c, double h)
            : base(name, a, b)
        {
            C = c;
            H = h;
        }

        public override double GetArea()
        {
            return (B * H) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + C;
        }

        protected void ValidateC(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Side C must be greater than zero.");
        }

        protected void ValidateH(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Height must be greater than zero.");
        }
    }
}