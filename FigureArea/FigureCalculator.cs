namespace FigureArea;

public static class FigureCalculator
{
    /// <summary>
    /// Метод позволяющий вычислять площадь фигуры без знания типа фигуры в compile-time
    /// </summary>
    /// <param name="figure"></param>
    /// <returns>Площадь фигуры</returns>
    public static double CalculateArea(IFigure figure)
    {
        return figure.GetArea();
    }
}
