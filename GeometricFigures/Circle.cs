namespace GeometricFigures
{
    public class Circle : IFigure
    {
        public double Radius
        {
            get => _radius;
            private init
            {
                if (value <= 0)
                {
                    throw new ArgumentException(RadiusNotValidMessage);
                }
                _radius = value;
            }
        }

        private readonly double _radius;
        public const double Pi = 3.14;
        public const string RadiusNotValidMessage = "Radius must be greater than 0.";

        public Circle(double r)
        {
            Radius = r;
        }

        public double CalculateArea()
        {
            return _radius * _radius * Pi;
        }

        public double CalculatePerimeterOrLength()
        {
            return 2 * Pi * _radius;
        }
    }
}
