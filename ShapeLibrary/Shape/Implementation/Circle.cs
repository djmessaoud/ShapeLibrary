namespace ShapeLibrary.Shape.Implementation;

public class Circle : IShape
{
    /// <summary>
    /// Радиус круга (>0)
    /// </summary>
    public double Radius { get; set; }

    public Circle(double radius)
    {
        if (radius < 0)
            throw new ArgumentException("Радиус отрицательный");
        Radius = radius;
    }
    /// <summary>
    /// Вычислите площадь круга
    /// </summary>
    /// <returns>Площадь (double)</returns>
    public double Area()
      =>  Math.Pow(Radius,2) * Math.PI;


}