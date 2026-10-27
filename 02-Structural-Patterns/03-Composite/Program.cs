var menu = new Menu("Menu principal");
menu.Add(new MenuItem("Accueil"));

var products = new Menu("Produits");
products.Add(new MenuItem("Ordinateurs"));
products.Add(new MenuItem("Téléphones"));
menu.Add(products);

menu.Display();

public abstract class MenuComponent(string name)
{
    public string Name { get; } = name;
    public abstract void Display(int indent = 0);
}

public sealed class MenuItem(string name) : MenuComponent(name)
{
    public override void Display(int indent = 0) =>
        Console.WriteLine($"{new string(' ', indent)}- {Name}");
}

public sealed class Menu(string name) : MenuComponent(name)
{
    private readonly List<MenuComponent> _children = [];

    public void Add(MenuComponent component) => _children.Add(component);

    public override void Display(int indent = 0)
    {
        Console.WriteLine($"{new string(' ', indent)}+ {Name}");
        foreach (var child in _children)
        {
            child.Display(indent + 2);
        }
    }
}
