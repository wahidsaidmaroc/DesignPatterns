ICoffee coffee = new SyrupDecorator(new MilkDecorator(new BasicCoffee()));
Console.WriteLine($"{coffee.GetDescription()} : {coffee.GetCost():F2} EUR");

public interface ICoffee
{
    string GetDescription();
    decimal GetCost();
}

public sealed class BasicCoffee : ICoffee
{
    public string GetDescription() => "Café";
    public decimal GetCost() => 2m;
}

public sealed class MilkDecorator(ICoffee coffee) : ICoffee
{
    public string GetDescription() => $"{coffee.GetDescription()} + lait";
    public decimal GetCost() => coffee.GetCost() + 0.5m;
}

public sealed class SyrupDecorator(ICoffee coffee) : ICoffee
{
    public string GetDescription() => $"{coffee.GetDescription()} + sirop";
    public decimal GetCost() => coffee.GetCost() + 0.75m;
}
