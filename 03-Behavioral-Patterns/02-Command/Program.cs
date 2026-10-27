var lamp = new Lamp();
var turnOn = new TurnOnCommand(lamp);
var remote = new RemoteControl();

remote.Execute(turnOn);
remote.Undo();

public interface ICommand
{
    void Execute();
    void Undo();
}

public sealed class Lamp
{
    public void TurnOn() => Console.WriteLine("Lampe allumée.");
    public void TurnOff() => Console.WriteLine("Lampe éteinte.");
}

public sealed class TurnOnCommand(Lamp lamp) : ICommand
{
    public void Execute() => lamp.TurnOn();
    public void Undo() => lamp.TurnOff();
}

public sealed class RemoteControl
{
    private ICommand? _lastCommand;

    public void Execute(ICommand command)
    {
        command.Execute();
        _lastCommand = command;
    }

    public void Undo() => _lastCommand?.Undo();
}
