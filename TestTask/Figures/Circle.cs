using TestTask.Common;

namespace TestTask.Figures;
public class Circle : IFigure
{
    /// <summary>
    /// Радиус круга
    /// </summary>
    public double Radius { get; }
    /// <summary>
    /// Площадь круга
    /// </summary>
    public double СalculationArea => Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
    public Circle(double radius)
    {
        Radius = radius;
        Validation();
    }

    private void Validation()
    {
        if (Radius < 0) throw new ArgumentOutOfRangeException("Радиус круга не может быть меньше нуля");
    }
}
