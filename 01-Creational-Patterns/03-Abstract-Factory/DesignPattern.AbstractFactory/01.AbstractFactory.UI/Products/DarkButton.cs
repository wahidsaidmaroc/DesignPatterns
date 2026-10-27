namespace DesignPattern.AbstractFactory.Products;

public sealed class DarkButton : IButton
{
    public string Render() => "Dark theme button rendered.";
}
