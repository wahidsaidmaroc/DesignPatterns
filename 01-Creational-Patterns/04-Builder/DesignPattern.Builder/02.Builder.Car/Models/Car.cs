namespace DesignPattern.Builder.Car.Models;

public class Car
{
    public string Brand { get; internal set; } = string.Empty;
    public string Model { get; internal set; } = string.Empty;
    public string Color { get; internal set; } = string.Empty;
    public string Engine { get; internal set; } = string.Empty;
    public bool GPS { get; internal set; }
    public bool Camera { get; internal set; }
    public bool AutomaticTransmission { get; internal set; }
    public bool AirConditioning { get; internal set; }

    public override string ToString() => $"""
        Voiture :
          Brand : {Brand}
          Model : {Model}
          Color : {Color}
          Engine : {Engine}
          GPS : {(GPS ? "Activé" : "Désactivé")}
          Camera : {(Camera ? "Activée" : "Désactivée")}
          AutomaticTransmission : {(AutomaticTransmission ? "Activée" : "Désactivée")}
          AirConditioning : {(AirConditioning ? "Activée" : "Désactivée")}
        """;
}
