namespace DesignPattern.AbstractFactory.Products;

public sealed class DarkCheckbox : ICheckbox
{
    public string Render() => "Dark theme checkbox rendered.";
}
