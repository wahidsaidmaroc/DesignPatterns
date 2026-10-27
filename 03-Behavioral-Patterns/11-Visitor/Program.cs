IShape[] shapes = [new Circle(2), new Rectangle(3, 4)];
var visitor = new AreaVisitor();

foreach (var shape in shapes)
{
    Console.WriteLine($"{shape.Name} : {shape.Accept(visitor):F2} unités²");
}

public interface IShape
{
    string Name { get; }
    double Accept(IShapeVisitor visitor);
}

public interface IShapeVisitor
{
    double Visit(Circle circle);
    double Visit(Rectangle rectangle);
}

public sealed record Circle(double Radius) : IShape
{
    public string Name => "Cercle";
    public double Accept(IShapeVisitor visitor) => visitor.Visit(this);
}

public sealed record Rectangle(double Width, double Height) : IShape
{
    public string Name => "Rectangle";
    public double Accept(IShapeVisitor visitor) => visitor.Visit(this);
}

public sealed class AreaVisitor : IShapeVisitor
{
    public double Visit(Circle circle) => Math.PI * circle.Radius * circle.Radius;
    public double Visit(Rectangle rectangle) => rectangle.Width * rectangle.Height;
}
