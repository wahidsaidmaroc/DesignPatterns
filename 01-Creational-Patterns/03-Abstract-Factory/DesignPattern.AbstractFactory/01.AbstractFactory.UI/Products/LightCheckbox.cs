namespace DesignPattern.AbstractFactory.Products;

public sealed class LightCheckbox : ICheckbox
{
    public string Render() => "Light theme checkbox rendered.";
}
