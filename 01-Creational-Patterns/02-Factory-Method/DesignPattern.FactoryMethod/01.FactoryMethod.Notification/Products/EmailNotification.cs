namespace DesignPattern.FactoryMethod.Products;

public sealed class EmailNotification : INotification
{
    public void Deliver(string recipient, string message)
    {
        Console.WriteLine($"Email sent to {recipient}: {message}");
    }
}
