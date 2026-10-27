namespace DesignPattern.FactoryMethod.Products;

public sealed class PushNotification : INotification
{
    public void Deliver(string recipient, string message)
    {
        Console.WriteLine($"Push notification sent to {recipient}: {message}");
    }
}
