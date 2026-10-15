namespace DesignPattern.Builder.VirtualMachine.Builders;

public class VirtualMachineBuilder
{
    private readonly Models.VirtualMachine _virtualMachine = new();

    public VirtualMachineBuilder SetName(string name)
    {
        _virtualMachine.Name = name;
        Console.WriteLine($"→ Name : {name}");
        // this rend possible la configuration fluide, étape par étape.
        return this;
    }

    public VirtualMachineBuilder SetCpu(int cpu)
    {
        _virtualMachine.CPU = cpu;
        Console.WriteLine($"→ CPU : {cpu}");
        return this;
    }

    public VirtualMachineBuilder SetRam(int ram)
    {
        _virtualMachine.RAM = ram;
        Console.WriteLine($"→ RAM : {ram} GB");
        return this;
    }

    public VirtualMachineBuilder SetStorage(int storage)
    {
        _virtualMachine.Storage = storage;
        Console.WriteLine($"→ Storage : {storage} GB");
        return this;
    }

    public VirtualMachineBuilder SetOperatingSystem(string operatingSystem)
    {
        _virtualMachine.OperatingSystem = operatingSystem;
        Console.WriteLine($"→ OS : {operatingSystem}");
        return this;
    }

    public VirtualMachineBuilder SetRegion(string region)
    {
        _virtualMachine.Region = region;
        Console.WriteLine($"→ Region : {region}");
        return this;
    }

    public VirtualMachineBuilder EnablePublicIp()
    {
        _virtualMachine.PublicIP = true;
        Console.WriteLine("→ Public IP : Activée");
        return this;
    }

    public VirtualMachineBuilder EnableBackup()
    {
        _virtualMachine.Backup = true;
        Console.WriteLine("→ Backup : Activé");
        return this;
    }

    // Un Builder par objet : Build retourne l'instance préparée.
    public Models.VirtualMachine Build()
    {
        Console.WriteLine("→ Build()");
        return _virtualMachine;
    }
}
