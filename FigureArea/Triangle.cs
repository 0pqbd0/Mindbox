namespace FigureArea;

public class Triangle : IFigure
{
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }

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

    public bool IsRightTriangle(double firstSide, double secondSide, double thirdSide)
    {
        return ((firstSide * firstSide + secondSide * secondSide == thirdSide * thirdSide)
            || (firstSide * firstSide + thirdSide * thirdSide == secondSide * secondSide)
            || (thirdSide * thirdSide + secondSide * secondSide == firstSide * firstSide));
    }

    public bool IsValidTriangle(double firstSide, double secondSide, double thirdSide)
    {
        return firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide
            && secondSide + thirdSide > firstSide;
    }

    public double GetArea()
    {
        double semiperimeter = (FirstSide + SecondSide + ThirdSide) / 2;

        return Math.Sqrt(semiperimeter * (semiperimeter - FirstSide) 
            * (semiperimeter - SecondSide) * (semiperimeter - ThirdSide));
    }
}
