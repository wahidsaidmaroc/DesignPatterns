namespace DesignPattern.Builder.Pizza.Builders;

public class PizzaBuilder
{
    private readonly Models.Pizza _pizza = new();

    public PizzaBuilder SetSize(string size)
    {
        _pizza.Size = size;
        Console.WriteLine($"→ Size : {size}");
        // Retourner this permet d'enchaîner les ingrédients.
        return this;
    }

    public PizzaBuilder AddCheese()
    {
        _pizza.Cheese = true;
        Console.WriteLine("→ Cheese : Oui");
        return this;
    }

    public PizzaBuilder AddTomato()
    {
        _pizza.Tomato = true;
        Console.WriteLine("→ Tomato : Oui");
        return this;
    }

    public PizzaBuilder AddOlives()
    {
        _pizza.Olives = true;
        Console.WriteLine("→ Olives : Oui");
        return this;
    }

    public PizzaBuilder AddMushrooms()
    {
        _pizza.Mushrooms = true;
        Console.WriteLine("→ Mushrooms : Oui");
        return this;
    }

    public PizzaBuilder AddChicken()
    {
        _pizza.Chicken = true;
        Console.WriteLine("→ Chicken : Oui");
        return this;
    }

    // Un Builder par objet : Build retourne l'instance préparée.
    public Models.Pizza Build()
    {
        Console.WriteLine("→ Build()");
        return _pizza;
    }
}
