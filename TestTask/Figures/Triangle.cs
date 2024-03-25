using TestTask.Common;

namespace TestTask.Figures;

public class Triangle : IFigure
{
    /// <summary>
    /// Длина первой стороны
    /// </summary>
    public double AB { get; }
    /// <summary>
    /// Длина второй стороны
    /// </summary>
    public double BC { get; }
    /// <summary>
    /// Длина третьей стороны
    /// </summary>
    public double AC { get; }
    /// <summary>
    /// Является ли треугольник прямоугольным
    /// </summary>
    public bool IsRectangular => CheckRectangular();
    /// <summary>
    /// Площадь треугольника
    /// </summary>
    public double СalculationArea => Math.Round(Math.Sqrt(HalfPerimeter * (HalfPerimeter - AB) * (HalfPerimeter - BC) * (HalfPerimeter - AC)), 2);
    private double HalfPerimeter => (AB + BC + AC) / 2;

    public Triangle(double ab, double bc, double ac)
    {
        AB = ab;
        BC = bc;
        AC = ac;
        IsValid();
    }

    private bool CheckRectangular() =>
        AB == Math.Sqrt(Math.Pow(BC, 2) + Math.Pow(AC, 2))
        || BC == Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(AC, 2))
        || AC == Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(BC, 2));

    private void IsValid()
    {
        if (AB >= BC + AC || BC >= AB + AC || AC >= AB + BC) throw new ArgumentOutOfRangeException("Треугольник с такими длинами не может существовать");
        if (AB <= 0 || BC <= 0 || AC <= 0) throw new ArgumentOutOfRangeException("Треугольник с такими длинами не может существовать");
    }

}


