namespace DesignPattern.Builder.Pizza.Models;

public class Pizza
{
    public string Size { get; internal set; } = string.Empty;
    public bool Cheese { get; internal set; }
    public bool Tomato { get; internal set; }
    public bool Olives { get; internal set; }
    public bool Mushrooms { get; internal set; }
    public bool Chicken { get; internal set; }

    public override string ToString() => $"""
        Pizza :
          Size : {Size}
          Cheese : {(Cheese ? "Oui" : "Non")}
          Tomato : {(Tomato ? "Oui" : "Non")}
          Olives : {(Olives ? "Oui" : "Non")}
          Mushrooms : {(Mushrooms ? "Oui" : "Non")}
          Chicken : {(Chicken ? "Oui" : "Non")}
        """;
}
