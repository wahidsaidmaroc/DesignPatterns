public interface IButton
{
    void Render();
}

public interface IWindow
{
    void Render();
}

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Windows Button");
    }
}

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Mac Button");
    }
}

public class WindowsWindow : IWindow
{
    public void Render()
    {
        Console.WriteLine("Rendering Windows Window");
    }
}

public class MacWindow : IWindow
{
    public void Render()
    {
        Console.WriteLine("Rendering Mac Window");
    }
}

public interface IGUIFactory
{
    IButton CreateButton();
    IWindow CreateWindow();
}

public class WindowsFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public IWindow CreateWindow()
    {
        return new WindowsWindow();
    }
}

public class MacFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public IWindow CreateWindow()
    {
        return new MacWindow();
    }
}

class Program
{
    static void Main()
    {
        IGUIFactory factory;

        // Choisir la fabrique en fonction de la plateforme
        string platform = "Windows"; // ou "Mac"
        if (platform == "Windows")
        {
            factory = new WindowsFactory();
        }
        else
        {

        }
        {
            factory = new MacFactory();
        }

        // Créer les produits en utilisant la fabrique abstraite
        IButton button = factory.CreateButton();
        IWindow window = factory.CreateWindow();

        // Utiliser les produits
        button.Render();
        window.Render();
    }
}
