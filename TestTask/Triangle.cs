namespace TestTask;

public class Triangle : Figure
{
    public double AB { get; set; }
    public double BC { get; set; }
    public double AC { get; set; }
    public bool IsRectangular => CheckRectangular();
    private double HalfPerimeter => (AB + BC + AC) / 2;


    public Triangle(double ab, double bc, double ac)
    {
        AB = ab;
        BC = bc;
        AC = ac;
        IsValid();
    }

    public override double СalculationArea() => Math.Round(Math.Sqrt(HalfPerimeter * (HalfPerimeter - AB) * (HalfPerimeter - BC) * (HalfPerimeter - AC)), 2);

    private bool CheckRectangular() =>
        AB == Math.Sqrt(Math.Pow(BC, 2) + Math.Pow(AC, 2))
        || BC == Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(AC, 2))
        || AC == Math.Sqrt(Math.Pow(AB, 2) + Math.Pow(BC, 2));

    private void IsValid()
    {
        if (AB >= BC + AC || BC >= AB + AC || AC >= AB + BC) throw new ArgumentException("Треугольник с такими длинами не может существовать");
        if (AB <= 0 || BC <= 0 || AC <= 0) throw new ArgumentException("Треугольник с такими длинами не может существовать");
    }

}


