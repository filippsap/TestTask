using NUnit.Framework;

namespace TestTask.Tests;

public class CircleTest
{
    [Test]
    public void CircleNegativeRadius()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-10));
    }
}