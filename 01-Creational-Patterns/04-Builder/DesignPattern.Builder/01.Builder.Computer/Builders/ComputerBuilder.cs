using DesignPattern.Builder.Computer.Models;

namespace DesignPattern.Builder.Computer.Builders;

public class ComputerBuilder
{
    private readonly Models.Computer _computer = new();

    public ComputerBuilder SetCpu(string cpu)
    {
        _computer.CPU = cpu;
        Console.WriteLine($"→ CPU : {cpu}");
        // Retourner le Builder courant permet le Fluent Interface.
        return this;
    }

    public ComputerBuilder SetRam(int ram)
    {
        _computer.RAM = ram;
        Console.WriteLine($"→ RAM : {ram} GB");
        return this;
    }

    public ComputerBuilder SetStorage(int storage)
    {
        _computer.Storage = storage;
        Console.WriteLine($"→ Storage : {storage} GB");
        return this;
    }

    public ComputerBuilder SetGpu(string gpu)
    {
        _computer.GPU = gpu;
        Console.WriteLine($"→ GPU : {gpu}");
        return this;
    }

    public ComputerBuilder EnableWifi()
    {
        _computer.WiFi = true;
        Console.WriteLine("→ WiFi : Activé");
        return this;
    }

    public ComputerBuilder SetOperatingSystem(string operatingSystem)
    {
        _computer.OperatingSystem = operatingSystem;
        Console.WriteLine($"→ OS : {operatingSystem}");
        return this;
    }

    // Un Builder par objet : Build retourne ici l'instance préparée, sans la copier.
    public Models.Computer Build()
    {
        Console.WriteLine("→ Build()");
        return _computer;
    }
}
