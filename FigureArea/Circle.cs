namespace FigureArea;

public class Circle : IFigure
{
    public double Radius { get; }

    /// <summary>
    /// Конструктор круга по радиусу
    /// </summary>
    /// <param name="radius">Радиус окружности</param>
    /// <exception cref="ArgumentException">Радиус должен быть положительным</exception>
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Радиус должен быть положительным!");
        }
        Radius = radius;
    }

    /// <summary>
    /// Метод для вычисления площади круга
    /// </summary>
    /// <returns>Площадь круга</returns>
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}