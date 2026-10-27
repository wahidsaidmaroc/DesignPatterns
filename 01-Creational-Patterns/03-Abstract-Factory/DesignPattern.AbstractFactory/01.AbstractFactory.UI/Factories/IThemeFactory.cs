using DesignPattern.AbstractFactory.Products;

namespace DesignPattern.AbstractFactory.Factories;

public interface IThemeFactory
{
    IButton CreateButton();

    ICheckbox CreateCheckbox();
}
