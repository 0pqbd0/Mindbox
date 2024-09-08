namespace FigureArea.Tests;

[TestClass]
public class FigureCalculatorTests
{
    [TestMethod]
    public void FigureCalculatorWithCircle()
    {
        IFigure someFigure = new Circle(2000);
        double area = FigureCalculator.CalculateArea(someFigure);
        double expectedResult = Math.PI * 2000 * 2000;
        Assert.AreEqual(expectedResult, area, 0.0001);
    }

    [TestMethod]
    public void FigureCalculatorWithTriangle()
    {

        IFigure someFigure = new Triangle(5, 4, 8);
        double area = FigureCalculator.CalculateArea(someFigure);
        double semiperimeter = (5 + 4 + 8) / 2.0;
        double expectedResult = Math.Sqrt(semiperimeter * (semiperimeter - 5)
            * (semiperimeter - 4) * (semiperimeter - 8));
        Assert.AreEqual(expectedResult, area, 0.0001);
    } 
}
