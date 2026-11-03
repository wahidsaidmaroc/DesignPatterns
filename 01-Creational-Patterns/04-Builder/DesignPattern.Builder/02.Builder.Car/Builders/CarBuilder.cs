namespace DesignPattern.Builder.Car.Builders;

public class CarBuilder
{
    private readonly Models.Car _car = new();

    public CarBuilder SetBrand(string brand)
    {
        _car.Brand = brand;
        return this;
    }

    public CarBuilder SetModel(string model)
    {
        _car.Model = model;
        return this;
    }

    public CarBuilder SetColor(string color)
    {
        _car.Color = color;
        Console.WriteLine($"→ Color : {color}");
        return this;
    }

    public CarBuilder SetEngine(string engine)
    {
        _car.Engine = engine;
        Console.WriteLine($"→ Engine : {engine}");
        return this;
    }

    public CarBuilder AddGps()
    {
        _car.GPS = true;
        return this;
    }

    public CarBuilder AddCamera()
    {
        _car.Camera = true;
        return this;
    }

    public CarBuilder EnableAutomaticTransmission()
    {
        _car.AutomaticTransmission = true;
        Console.WriteLine("→ AutomaticTransmission : Activée");
        return this;
    }

    public CarBuilder EnableAirConditioning()
    {
        _car.AirConditioning = true;
        Console.WriteLine("→ AirConditioning : Activée");
        return this;
    }

    // Un Builder par objet : Build retourne l'instance préparée.
    public Models.Car Build()
    {
        Console.WriteLine("→ Build()");
        return _car;
    }
}
