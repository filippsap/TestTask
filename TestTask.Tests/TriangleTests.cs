using NUnit.Framework;
using TestTask.Figures;

namespace TestTask.Tests;

public class TriangleTests
{

    [Test]
    public void NegativeLengths()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, 0, 0));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -10, 0));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -10));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-10, -10, -10));
    }

    [Test]
    public void ImpossibleLengths()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(50,4,10));
    }

    [Test]
    public void �alculationArea()
    {
        //Arrange
        var triangle = new Triangle(5, 14, 13);

        //Act
        var triangleSquare = triangle.�alculationArea;

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