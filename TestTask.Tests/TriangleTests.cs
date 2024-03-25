using NUnit.Framework;

namespace TestTask.Tests;

public class TriangleTests
{

    [Test]
    public void TriangleNegativeValues()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-10, 0, 0));
        Assert.Throws<ArgumentException>(() => new Triangle(0, -10, 0));
        Assert.Throws<ArgumentException>(() => new Triangle(0, 0, -10));
        Assert.Throws<ArgumentException>(() => new Triangle(-10, -10, -10));
    }

    [Test]
    public void ImpossibleTriangle()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(50,4,10));
    }

    [Test]
    public void ÑalculationArea()
    {
        //Arrange
        var triangle = new Triangle(5, 14, 13);

        //Act
        var triangleSquare = triangle.ÑalculationArea();

        //Assert
        Assert.That(triangleSquare, Is.EqualTo(32.5));
    }

    [Test]
    public void IsRectangular()
    {
        //Arrange
        var triangle = new Triangle(6, 10, 8);

        //Act
        var isTriangleRightAngled = triangle.IsRectangular;

        //Assert
        Assert.That(isTriangleRightAngled, Is.EqualTo(true));
    }

    [Test]
    public void IsNotRectangular()
    {
        //Arrange
        var triangle = new Triangle(5, 5, 8);

        //Act
        var isTriangleRightAngled = triangle.IsRectangular;

        //Assert
        Assert.That(isTriangleRightAngled, Is.EqualTo(false));
    }
}