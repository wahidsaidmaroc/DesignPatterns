using DesignPattern.AbstractFactory.Products;

namespace DesignPattern.AbstractFactory.Factories;

public sealed class DarkThemeFactory : IThemeFactory
{
    public IButton CreateButton() => new DarkButton();

    public ICheckbox CreateCheckbox() => new DarkCheckbox();
}
