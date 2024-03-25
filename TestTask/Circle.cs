namespace TestTask;

public class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
        IsValid();
    }

    public override double СalculationArea() => Math.Round(Math.PI * Math.Pow(Radius, 2), 2);

    public void IsValid()
    {
        if (Radius < 0) throw new ArgumentException("Радиус круга не может быть меньше нуля");
    }
}
