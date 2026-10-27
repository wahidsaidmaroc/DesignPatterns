var checkout = new Checkout(new StandardDelivery());
Console.WriteLine($"Livraison standard : {checkout.Calculate(10m):F2} EUR");

checkout.SetStrategy(new ExpressDelivery());
Console.WriteLine($"Livraison express : {checkout.Calculate(10m):F2} EUR");

public interface IDeliveryStrategy
{
    decimal Calculate(decimal weight);
}

public sealed class StandardDelivery : IDeliveryStrategy
{
    public decimal Calculate(decimal weight) => 5m + weight;
}

public sealed class ExpressDelivery : IDeliveryStrategy
{
    public decimal Calculate(decimal weight) => 10m + weight * 2m;
}

public sealed class Checkout(IDeliveryStrategy strategy)
{
    private IDeliveryStrategy _strategy = strategy;

    public void SetStrategy(IDeliveryStrategy strategy) => _strategy = strategy;
    public decimal Calculate(decimal weight) => _strategy.Calculate(weight);
}
