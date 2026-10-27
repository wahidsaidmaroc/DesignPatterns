var station = new WeatherStation();
station.Subscribe(new WeatherDisplay("Cuisine"));
station.Subscribe(new WeatherDisplay("Salon"));
station.SetTemperature(21);

public interface IWeatherObserver
{
    void Update(int temperature);
}

public sealed class WeatherDisplay(string name) : IWeatherObserver
{
    public void Update(int temperature) =>
        Console.WriteLine($"{name} : température mise à jour à {temperature} °C.");
}

public sealed class WeatherStation
{
    private readonly List<IWeatherObserver> _observers = [];

    public void Subscribe(IWeatherObserver observer) => _observers.Add(observer);

    public void SetTemperature(int temperature)
    {
        Console.WriteLine($"Nouvelle température : {temperature} °C.");
        foreach (var observer in _observers)
        {
            observer.Update(temperature);
        }
    }
}
