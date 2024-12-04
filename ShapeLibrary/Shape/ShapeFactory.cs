using ShapeLibrary.Shape.Implementation;

namespace ShapeLibrary.Shape;

/// <summary>
/// Фабрика для создания фигур в runtime
/// </summary>
public class ShapeFactory
{
    /// <summary>
    /// создавать круга с радиусом
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
    public static Circle CreateCircle(double radius) => new Circle(radius);
    /// <summary>
    /// создавать треугольник с длинами сторон
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    /// <returns></returns>
    public static Triangle CreateTriangle(double a, double b, double c) => new Triangle(a, b, c);
}