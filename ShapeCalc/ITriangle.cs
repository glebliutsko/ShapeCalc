namespace ShapeCalc;

public enum TypeTriangle
{
    Right = 1, // Прямоугольный
    Obtuse = 2, // Тупоугольный
    Acute = 3 // Остроугольный
}

public interface ITriangle : IShape
{
    TypeTriangle GetTypeTriangle();
}