namespace DesignPattern.Builder.Computer.Models;

// Le modèle représente le résultat, sans connaître les étapes de construction.
public class Computer
{
    public string CPU { get; internal set; } = string.Empty;
    public int RAM { get; internal set; }
    public int Storage { get; internal set; }
    public string GPU { get; internal set; } = string.Empty;
    public bool WiFi { get; internal set; }
    public string OperatingSystem { get; internal set; } = string.Empty;

    public override string ToString() => $"""
        Ordinateur :
          CPU : {CPU}
          RAM : {RAM} GB
          Storage : {Storage} GB
          GPU : {GPU}
          WiFi : {(WiFi ? "Activé" : "Désactivé")}
          OperatingSystem : {OperatingSystem}
        """;
}
