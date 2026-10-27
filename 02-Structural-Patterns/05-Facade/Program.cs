var theater = new HomeTheaterFacade(
    new Television(),
    new SoundSystem(),
    new Projector());

theater.WatchMovie("Le voyage");
theater.EndMovie();

public sealed class Television
{
    public void TurnOn() => Console.WriteLine("Télévision allumée.");
    public void TurnOff() => Console.WriteLine("Télévision éteinte.");
}

public sealed class SoundSystem
{
    public void TurnOn() => Console.WriteLine("Son activé.");
    public void TurnOff() => Console.WriteLine("Son désactivé.");
}

public sealed class Projector
{
    public void TurnOn() => Console.WriteLine("Projecteur allumé.");
    public void TurnOff() => Console.WriteLine("Projecteur éteint.");
}

public sealed class HomeTheaterFacade(
    Television television,
    SoundSystem sound,
    Projector projector)
{
    public void WatchMovie(string title)
    {
        Console.WriteLine($"Préparation du film : {title}");
        television.TurnOn();
        sound.TurnOn();
        projector.TurnOn();
    }

    public void EndMovie()
    {
        projector.TurnOff();
        sound.TurnOff();
        television.TurnOff();
    }
}
