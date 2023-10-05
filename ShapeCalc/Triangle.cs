namespace ShapeCalc;

public class Triangle : ITriangle
{
    private double[] _sides;

    public double[] Sides
    {
        get => _sides;
        set
        {
            if (value.Length != 3)
                throw new ArgumentException("Length array \"Sides\" should be equal to 3");
            if (value.Any(x => x <= 0))
                throw new ArgumentOutOfRangeException("All sides should be positive");
            
            _sides = value;
        }
    }

    public Triangle(double[] sides)
    {
        Sides = sides;
    }

    public Triangle(double x, double y, double z) : this(new double[] {x, y, z})
    { }
    
    public double GetArea()
    {
        var p = Sides.Sum() / 2d;
        // S = Sqrt(p * (p - a) * (p - b) * (p - c))
        return Math.Sqrt(p * Sides.Select(x => p - x).Aggregate((x, y) => x * y));
    }

    public TypeTriangle GetTypeTriangle()
    {
        var smallerSides = Sides.Order().Take(2).ToArray();
        var biggerSide = Sides.Max();

        var squareBiggerSide = biggerSide * biggerSide;
        var sumSquareSmallerSides = smallerSides.Select(x => x * x).Sum();

        if (squareBiggerSide == sumSquareSmallerSides)
            return TypeTriangle.Right;
        else if (squareBiggerSide > sumSquareSmallerSides)
            return TypeTriangle.Obtuse;
        else
            return TypeTriangle.Acute;
    }
}