using GeometricFigures;

namespace FigureTests
{
    [TestClass]
    public class GeometricFigureTestClass
    {
        #region Calculate Tests

        [TestMethod]
        public void CalculateArea_CheckTriangleArea_CorrectTriangleData()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double correctArea = 6;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            var area = triangle.CalculateArea();
            Assert.AreEqual(correctArea, area);
        }

        [TestMethod]
        public void CalculatePerimeterOrLength_CheckCalculatePerimeter_CorrectTriangleData()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            double correctPerimeter = 12;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            var perimeter = triangle.CalculatePerimeterOrLength();
            Assert.AreEqual(correctPerimeter, perimeter);
        }

        [TestMethod]
        public void IsTriangleRectangular_CheckIsTriangleRectangular_TriangleIsRectangle()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            var isRectangular = triangle.IsTriangleRectangular();
            Assert.AreEqual(true, isRectangular);
        }

        [TestMethod]
        public void IsTriangleRectangular_CheckIsTriangleRectangular_TriangleIsNotRectangle()
        {
            double sideA = 3;
            double sideB = 5;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            var isRectangular = triangle.IsTriangleRectangular();
            Assert.AreEqual(false, isRectangular);
        }

        [TestMethod]
        public void CalculateArea_CheckCircleArea_CorrectCircleData()
        {
            double radius = 3;
            Circle circle = new Circle(radius);
            double correctArea = radius * radius * Circle.Pi;
            var area = circle.CalculateArea();
            Assert.AreEqual(correctArea, area);
        }

        [TestMethod]
        public void CalculatePerimeterOrLength_CheckCircleLength_CorrectCircleData()
        {
            double radius = 3;
            Circle circle = new Circle(radius);
            double correctArea = 2 * radius * Circle.Pi;
            var area = circle.CalculatePerimeterOrLength();
            Assert.AreEqual(correctArea, area);
        }

        #endregion

        #region Create Tests

        [TestMethod]
        public void Circle_CreateNewCircleByConstructor_RadiusIsZero()
        {
            double radius = 0;
            try
            {
                _ = new Circle(radius);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, Circle.RadiusNotValidMessage);
            }
        }

        [TestMethod]
        public void Triangle_CreateNewTriangleByConstructor_SidesNotCorrect()
        {
            double sideA = 3;
            double sideB = 5;
            double sideC = 12;
            try
            {
                _ = new Triangle(sideA, sideB, sideC);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message, Triangle.SidesNotValidMessage);
            }
        }

        #endregion
    }
}