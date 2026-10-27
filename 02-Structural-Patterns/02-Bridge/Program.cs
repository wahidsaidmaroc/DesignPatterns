Message message = new Alert(new EmailSender());
message.Send("Le serveur est disponible.");

message = new Reminder(new SmsSender());
message.Send("Votre rendez-vous est demain.");

public interface IMessageSender
{
    void Send(string message);
}

public sealed class EmailSender : IMessageSender
{
    public void Send(string message) => Console.WriteLine($"E-mail : {message}");
}

public sealed class SmsSender : IMessageSender
{
    public void Send(string message) => Console.WriteLine($"SMS : {message}");
}

public abstract class Message(IMessageSender sender)
{
    public void Send(string text) => sender.Send(AddPrefix(text));
    protected abstract string AddPrefix(string text);
}

public sealed class Alert(IMessageSender sender) : Message(sender)
{
    protected override string AddPrefix(string text) => $"[ALERTE] {text}";
}

public sealed class Reminder(IMessageSender sender) : Message(sender)
{
    protected override string AddPrefix(string text) => $"[RAPPEL] {text}";
}
