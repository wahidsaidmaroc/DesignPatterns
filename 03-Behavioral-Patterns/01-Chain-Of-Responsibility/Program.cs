var manager = new Manager();
var director = new Director();
var board = new Board();
manager.SetNext(director).SetNext(board);

manager.Approve(750m);
manager.Approve(4_000m);
manager.Approve(12_000m);

public abstract class Approver
{
    private Approver? _next;

    public Approver SetNext(Approver next)
    {
        _next = next;
        return next;
    }

    public void Approve(decimal amount)
    {
        if (CanApprove(amount))
        {
            Console.WriteLine($"{GetType().Name} approuve {amount:F2} EUR.");
        }
        else if (_next is not null)
        {
            _next.Approve(amount);
        }
        else
        {
            Console.WriteLine($"Aucun approbateur pour {amount:F2} EUR.");
        }
    }

    protected abstract bool CanApprove(decimal amount);
}

public sealed class Manager : Approver
{
    protected override bool CanApprove(decimal amount) => amount <= 1_000m;
}

public sealed class Director : Approver
{
    protected override bool CanApprove(decimal amount) => amount <= 5_000m;
}

public sealed class Board : Approver
{
    protected override bool CanApprove(decimal amount) => amount <= 10_000m;
}
