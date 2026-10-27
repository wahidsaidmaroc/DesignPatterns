var room = new ChatRoom();
var alice = new ChatMember("Alice", room);
var bob = new ChatMember("Bob", room);
room.Register(alice);
room.Register(bob);

alice.Send("Bonjour !");
bob.Send("Salut Alice !");

public sealed class ChatRoom
{
    private readonly List<ChatMember> _members = [];

    public void Register(ChatMember member) => _members.Add(member);

    public void Send(string message, ChatMember sender)
    {
        foreach (var member in _members.Where(member => member != sender))
        {
            member.Receive(message, sender.Name);
        }
    }
}

public sealed class ChatMember(string name, ChatRoom room)
{
    public string Name { get; } = name;

    public void Send(string message) => room.Send(message, this);

    public void Receive(string message, string sender) =>
        Console.WriteLine($"{Name} reçoit de {sender} : {message}");
}
