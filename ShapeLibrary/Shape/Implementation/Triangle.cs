namespace ShapeLibrary.Shape.Implementation;

public class Triangle : IShape
{
    /// <summary>
    /// Первая сторона треугольника
    /// </summary>
    public double SideA = 0; 
    /// <summary>
    /// Вторая сторона треугольника
    /// </summary>
    public double SideB = 0; 
    /// <summary>
    /// третая сторона треугольника
    /// </summary>
    public double SideC = 0;
    /// <summary>
    /// Допуск (Delta) по умолчанию для проверки того, является ли треугольник правильным или нет 
    /// </summary>
    private const double DefaultToleranceDelta = 1e-7;
    /// <summary>
    /// Паблик Delta
    /// </summary>
    public double RightTriangleDelta { get; set; } = DefaultToleranceDelta;
    public Triangle(double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0) throw new ArgumentException("Все стороны должны иметь только положительные значения");
        if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            throw new ArgumentException("Треугольник не является правильным (стороны не образуют треугольник)");
        SideA = a;
        SideB = b;
        SideC = c;
    }

    public double Area()
    {
        var semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }
    /// <summary>
    /// Проверяет, является ли треугольник правильным или нет
    /// </summary>
    /// <returns>true, false</returns>
    public bool IsRightTriangle()
    {
        double[] sides = [SideA, SideB, SideC];
        Array.Sort(sides);
        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < RightTriangleDelta;
    }
    
}