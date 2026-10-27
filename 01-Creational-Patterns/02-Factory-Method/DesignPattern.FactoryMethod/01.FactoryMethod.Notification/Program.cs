using DesignPattern.FactoryMethod.Creators;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("====================================");
Console.WriteLine("FACTORY METHOD PATTERN DEMO");
Console.WriteLine("====================================");
Console.WriteLine("Factory Method lets subclasses decide which object to create.");
Console.WriteLine();

var creators = new NotificationCreator[]
{
    new EmailNotificationCreator(),
    new SmsNotificationCreator(),
    new PushNotificationCreator()
};

foreach (var creator in creators)
{
    Console.WriteLine($"--- {creator.GetType().Name} ---");
    creator.SendNotification("client@demo.com", "Your order has been shipped.");
    Console.WriteLine();
}

Console.WriteLine("Result: the client code depends only on abstractions.");
