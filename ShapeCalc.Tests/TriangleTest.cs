namespace ShapeCalc.Tests;

public class TriangleTest
{
    [Theory]
    [InlineData(new double[] {})]
    [InlineData(new double[] {6})]
    [InlineData(new double[] {8, 2})]
    [InlineData(new double[] {8, 2, 7, 8})]
    public void Sides_InvalidCount_Exception(double[] sides)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sides));
    }

    [Fact]
    public void Sides_ValidCount_Ok()
    {
        _ = new Triangle(new double[] {3, 5, 7});
    }

    [Theory]
    [InlineData(new double[] { -1d, 1d, 1d })]
    [InlineData(new double[] { 1d, -1d, 1d })]
    [InlineData(new double[] { 1d, 1d, -1d })]
    [InlineData(new double[] { -1d, -1d, -1d })]
    public void Sides_NegativeSide_Exception(double[] sides)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(sides));
    }

    [Fact]
    public void GetArea_ValidData_Result()
    {
        var triangle = new Triangle(16, 20, 12);

        var area = triangle.GetArea();
        
        Assert.Equal(96d, area);
    }

    [Fact]
    public void GetTypeTriangle_ValidData_Right()
    {
        var triangle = new Triangle(16, 20, 12);

        var typeTriangle = triangle.GetTypeTriangle();
        
        Assert.Equal(TypeTriangle.Right, typeTriangle);
    }
    
    [Fact]
    public void GetTypeTriangle_ValidData_Obtuse()
    {
        var triangle = new Triangle(6, 8, 12);

        var typeTriangle = triangle.GetTypeTriangle();
        
        Assert.Equal(TypeTriangle.Obtuse, typeTriangle);
    }
    
    [Fact]
    public void GetTypeTriangle_ValidData_Acute()
    {
        var triangle = new Triangle(6, 8, 6);

        var typeTriangle = triangle.GetTypeTriangle();
        
        Assert.Equal(TypeTriangle.Acute, typeTriangle);
    }
}