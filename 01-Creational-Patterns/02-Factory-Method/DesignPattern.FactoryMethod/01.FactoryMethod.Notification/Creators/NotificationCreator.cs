using DesignPattern.FactoryMethod.Products;

namespace DesignPattern.FactoryMethod.Creators;

public abstract class NotificationCreator
{
    public abstract INotification CreateNotification();

    public void SendNotification(string recipient, string message)
    {
        var notification = CreateNotification();
        notification.Deliver(recipient, message);
    }
}
