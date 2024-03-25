using NUnit.Framework;
using TestTask.Figures;

namespace TestTask.Tests;

public class CircleTest
{
    [Test]
    public void CircleNegativeRadius()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-4));
    }

    [Test]
    public void ÑalculationArea()
    {
        //Arrange
        var circle = new Circle(6);

        //Act
        var circleArea = circle.ÑalculationArea;

        //Assert
        Assert.That(circleArea, Is.EqualTo(113.1));
    }

}