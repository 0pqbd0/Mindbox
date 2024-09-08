namespace FigureArea.Tests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void CircleGetAreaTestWithCorrectDataCloseToTheLimit()
    {
        var circle = new Circle(0.1);
        double area = circle.GetArea();
        double expectedResult = Math.PI * 0.1 * 0.1;
        Assert.AreEqual(expectedResult, area, 0.0001);
    }

    [TestMethod]
    public void CircleGetAreaTestWithCorrectData()
    {
        var circle = new Circle(2000);
        double area = circle.GetArea();
        double expectedResult = Math.PI * 2000 * 2000;
        Assert.AreEqual(expectedResult, area, 0.0001);
    }

    [TestMethod()]
    public void CreateCircleTestWithIncorectRadius()
    {
        var ex = Assert.ThrowsException<ArgumentException>(() => new Circle(-5));
        Assert.AreEqual(ex.Message, "Радиус должен быть положительным!");
    }

}