namespace DesignPattern.FactoryMethod.Products;

public interface INotification
{
    void Deliver(string recipient, string message);
}
