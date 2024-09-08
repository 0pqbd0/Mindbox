namespace FigureArea.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void TriangleGetAreaTestWithCorrectDataCloseToTheLimit()
    {
        var triangle = new Triangle(0.1, 0.01, 0.1);
        double area = triangle.GetArea();
        double semiperimeter = (0.1 + 0.01 + 0.1) / 2;
        double expectedResult = Math.Sqrt(semiperimeter * (semiperimeter - 0.1)
            * (semiperimeter - 0.01) * (semiperimeter - 0.1));
        Assert.AreEqual(expectedResult, area, 0.0001);
    }

    [TestMethod]
    public void TriangleGetAreaTestWithCorrectData()
    {
        var triangle = new Triangle(5, 4, 8);
        double area = triangle.GetArea();
        double semiperimeter = (5 + 4 + 8) / 2.0; 
        double expectedResult = Math.Sqrt(semiperimeter * (semiperimeter - 5)
            * (semiperimeter - 4) * (semiperimeter - 8));
        Assert.AreEqual(expectedResult, area, 0.0001);
    }

    [TestMethod()]
    public void RightTriangleTrueTest()
    {
        var rightTriangle = new Triangle(3, 4, 5);
        bool isRightTriangle = rightTriangle.IsRightTriangle();
        Assert.IsTrue(isRightTriangle);
    }

    [TestMethod()]
    public void RightTriangleFalseTest()
    {
        var rightTriangle = new Triangle(3, 7, 5);
        bool isRightTriangle = rightTriangle.IsRightTriangle();
        Assert.IsFalse(isRightTriangle);
    }

    [TestMethod()]
    public void CreateTriangleTestWithIncorectFirstSide()
    {
        var ex = Assert.ThrowsException<ArgumentException>(() => new Triangle(0, 4, 8));
        Assert.AreEqual(ex.Message, "Сторона треугольника должна быть положительной!");
    }

    [TestMethod()]
    public void CreateTriangleTestWithIncorectSecondSide()
    {
        var ex = Assert.ThrowsException<ArgumentException>(() => new Triangle(1, -5, 8));
        Assert.AreEqual(ex.Message, "Сторона треугольника должна быть положительной!");
    }

    [TestMethod()]
    public void CreateTriangleTestWithIncorectThirdSide()
    {
        var ex = Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 5, -3));
        Assert.AreEqual(ex.Message, "Сторона треугольника должна быть положительной!");
    }

    [TestMethod()]
    public void CreateTriangleTestWithIncorectSides()
    {
        var ex = Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 5, 2));
        Assert.AreEqual(ex.Message, "По данным сторонам нельзя построить треугольник!");
    }
}