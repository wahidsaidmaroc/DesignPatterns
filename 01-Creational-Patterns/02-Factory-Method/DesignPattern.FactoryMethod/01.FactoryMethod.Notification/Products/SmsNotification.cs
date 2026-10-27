namespace DesignPattern.FactoryMethod.Products;

public sealed class SmsNotification : INotification
{
    public void Deliver(string recipient, string message)
    {
        Console.WriteLine($"SMS sent to {recipient}: {message}");
    }
}
