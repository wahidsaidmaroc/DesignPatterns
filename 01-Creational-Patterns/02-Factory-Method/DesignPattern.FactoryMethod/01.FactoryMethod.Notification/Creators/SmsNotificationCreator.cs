using DesignPattern.FactoryMethod.Products;

namespace DesignPattern.FactoryMethod.Creators;

public sealed class SmsNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification() => new SmsNotification();
}
