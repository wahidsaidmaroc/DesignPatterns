using DesignPattern.AbstractFactory.Factories;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("====================================");
Console.WriteLine("ABSTRACT FACTORY PATTERN DEMO");
Console.WriteLine("====================================");
Console.WriteLine("Abstract Factory creates families of related objects.");
Console.WriteLine();

var factories = new IThemeFactory[]
{
    new LightThemeFactory(),
    new DarkThemeFactory()
};

foreach (var factory in factories)
{
    Console.WriteLine($"--- {factory.GetType().Name} ---");

    var button = factory.CreateButton();
    var checkbox = factory.CreateCheckbox();

    Console.WriteLine(button.Render());
    Console.WriteLine(checkbox.Render());
    Console.WriteLine();
}

Console.WriteLine("Result: the theme stays consistent across all created controls.");
