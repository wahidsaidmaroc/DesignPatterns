namespace DesignPattern.AbstractFactory.Products;

public sealed class LightButton : IButton
{
    public string Render() => "Light theme button rendered.";
}
