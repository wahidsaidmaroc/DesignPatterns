using DesignPattern.FactoryMethod.Products;

namespace DesignPattern.FactoryMethod.Creators;

public sealed class PushNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification() => new PushNotification();
}
