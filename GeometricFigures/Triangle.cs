namespace GeometricFigures
{
    public class Triangle: IFigure
    {
        public const string SidesNotValidMessage = "Sides not valid.";

        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!TriangleIsValid(sideA, sideB, sideC))
            {
                throw new Exception(SidesNotValidMessage);
            }

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculatePerimeterOrLength()
        {
            return sideA + sideB + sideC;
        }

        public double CalculateArea()
        {
            var p = CalculatePerimeterOrLength() / 2.0f;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

        public bool IsTriangleRectangular()
        {
            return CheckIsRectangular(sideA, sideB, sideC)
                    || CheckIsRectangular(sideC, sideB, sideA)
                    || CheckIsRectangular(sideA, sideC, sideB);
        }

        private bool TriangleIsValid(double firstSide, double secondSide, double threadSide)
        {
            return firstSide > 0 && secondSide > 0 && threadSide > 0 
                   && SidesIsValid(firstSide, secondSide, threadSide) 
                   && SidesIsValid(firstSide, threadSide, secondSide) 
                   && SidesIsValid(secondSide, threadSide, firstSide);
        }

        private bool SidesIsValid(double firstSide, double secondSide, double threadSide)
        {
            return firstSide + secondSide > threadSide;
        }

        private bool CheckIsRectangular(double firstSide, double secondSide, double threadSide)
        {
            return Math.Abs(firstSide * firstSide + secondSide * secondSide - threadSide * threadSide) == 0;
        }
    }
}
