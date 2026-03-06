using System;

namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public double R
        {
            get => _r;
            set
            {
                ValidateR(value);
                _r = value;
            }
        }

        public Circle(string name, double r) : base(name)
        {
            R = r;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }

        private void ValidateR(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Radius must be greater than zero.");
        }
    }
}