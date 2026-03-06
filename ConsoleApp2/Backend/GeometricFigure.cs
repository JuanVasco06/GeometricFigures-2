using System.Globalization;

namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; }

        protected GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            string area = GetArea().ToString("N5", CultureInfo.InvariantCulture);
            string perimeter = GetPerimeter().ToString("N5", CultureInfo.InvariantCulture);

            return $"{Name,-15}=> Area......: {area,12}     Perimiter: {perimeter,12}";
        }
    }
}
