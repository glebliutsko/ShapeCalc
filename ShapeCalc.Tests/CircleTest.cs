namespace ShapeCalc.Tests;

public class CircleTest
{
    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    public void Radius_NegativeValue_Exception(double value)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
    }
    
    [Fact]
    public void Radius_SetNegativeValue_Exception()
    {
        var circle = new Circle(5);

        Assert.Throws<ArgumentOutOfRangeException>(() => { circle.Radius = -1; });
    }

    [Fact]
    public void GetArea_ValidData_Result()
    {
        var circle = new Circle(6);

        var area = circle.GetArea();
        
        Assert.Equal(113.097, Math.Round(area, 3));
    }
}