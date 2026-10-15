// Builder est un Design Pattern de création permettant de construire progressivement un objet complexe.
using DesignPattern.Builder.Car.Builders;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("====================================");
Console.WriteLine("BUILDER PATTERN DEMO");
Console.WriteLine("====================================");
Console.WriteLine("Builder est un Design Pattern de création permettant de construire progressivement un objet complexe.");
Console.WriteLine();

Console.WriteLine("1. Création du Builder");
Console.WriteLine("Création CarBuilder...");
var builder = new CarBuilder();

Console.WriteLine("\n2. Configuration des propriétés");
// Les options sont ajoutées progressivement, sans constructeur à nombreux paramètres.
builder.SetBrand("Toyota")
    .SetModel("Corolla")
    .SetColor("Black")
    .SetEngine("Hybrid")
    .AddGps()
    .AddCamera()
    .EnableAutomaticTransmission()
    .EnableAirConditioning();

Console.WriteLine("\n3. Construction de l'objet");
Console.WriteLine("Les étapes de configuration ont préparé la voiture.");
Console.WriteLine("\n4. Appel de Build()");
var car = builder.Build();
Console.WriteLine("Voiture créée avec succès.");

Console.WriteLine("\n5. Affichage de l'objet final");
Console.WriteLine(car);
Console.WriteLine("\nÀ retenir : Builder = construire un objet complexe étape par étape.");
