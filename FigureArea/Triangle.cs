namespace FigureArea;

public class Triangle : IFigure
{
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }

    /// <summary>
    /// Конструктор треугольника по трём сторонам
    /// </summary>
    /// <param name="firstSide"></param>
    /// <param name="secondSide"></param>
    /// <param name="thirdSide"></param>
    /// <exception cref="ArgumentException"></exception>
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
        {
            throw new ArgumentException("Сторона треугольника должна быть положительной!");
        }

        if (!IsValidTriangle(firstSide, secondSide, thirdSide))
        {
            throw new ArgumentException("По данным сторонам нельзя построить треугольник!");
        }

        FirstSide = firstSide;
        SecondSide = secondSide;
        ThirdSide = thirdSide;
    }

    /// <summary>
    /// Проыерка является ли треугольник прямоугольным
    /// </summary>
    /// <returns></returns>
    public bool IsRightTriangle()
    {
        return ((FirstSide * FirstSide + SecondSide * SecondSide == ThirdSide * ThirdSide)
            || (FirstSide * FirstSide + ThirdSide * ThirdSide == SecondSide * SecondSide)
            || (ThirdSide * ThirdSide + SecondSide * SecondSide == FirstSide * FirstSide));
    }

    /// <summary>
    /// Метод проверяющий существует ли треугольник с заланными сторонами
    /// </summary>
    /// <param name="firstSide"></param>
    /// <param name="secondSide"></param>
    /// <param name="thirdSide"></param>
    /// <returns></returns>
    public bool IsValidTriangle(double firstSide, double secondSide, double thirdSide)
    {
        return firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide
            && secondSide + thirdSide > firstSide;
    }

    /// <summary>
    /// Метод для вычисления площади трекгольника
    /// </summary>
    /// <returns>Площадь треугольника</returns>
    public double GetArea()
    {
        double semiperimeter = (FirstSide + SecondSide + ThirdSide) / 2.0;

        return Math.Sqrt(semiperimeter * (semiperimeter - FirstSide) 
            * (semiperimeter - SecondSide) * (semiperimeter - ThirdSide));
    }
}
