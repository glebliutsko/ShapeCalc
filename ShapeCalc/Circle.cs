namespace ShapeCalc;

public class Circle : IShape
{
    private double _radius;
    public double Radius
    {
        get => _radius;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("Radius should be positive");
            _radius = value;
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }
    
    public double GetArea()
    {
        // S = Pi * R^2
        return Math.PI * Radius * Radius;
    }
}