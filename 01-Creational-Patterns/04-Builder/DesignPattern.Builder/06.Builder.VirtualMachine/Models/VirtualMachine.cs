namespace DesignPattern.Builder.VirtualMachine.Models;

public class VirtualMachine
{
    public string Name { get; internal set; } = string.Empty;
    public int CPU { get; internal set; }
    public int RAM { get; internal set; }
    public int Storage { get; internal set; }
    public string OperatingSystem { get; internal set; } = string.Empty;
    public bool PublicIP { get; internal set; }
    public bool Backup { get; internal set; }
    public string Region { get; internal set; } = string.Empty;

    public override string ToString() => $"""
        Machine virtuelle :
          Name : {Name}
          CPU : {CPU}
          RAM : {RAM} GB
          Storage : {Storage} GB
          OperatingSystem : {OperatingSystem}
          PublicIP : {(PublicIP ? "Activée" : "Désactivée")}
          Backup : {(Backup ? "Activé" : "Désactivé")}
          Region : {Region}
        """;
}
