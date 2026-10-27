using DesignPattern.FactoryMethod.Products;

namespace DesignPattern.FactoryMethod.Creators;

public sealed class EmailNotificationCreator : NotificationCreator
{
    public override INotification CreateNotification() => new EmailNotification();
}
