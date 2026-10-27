using DesignPattern.AbstractFactory.Products;

namespace DesignPattern.AbstractFactory.Factories;

public sealed class LightThemeFactory : IThemeFactory
{
    public IButton CreateButton() => new LightButton();

    public ICheckbox CreateCheckbox() => new LightCheckbox();
}
