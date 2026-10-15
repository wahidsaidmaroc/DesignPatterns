// Builder est un Design Pattern de création permettant de construire progressivement un objet complexe.
using DesignPattern.Builder.Computer.Builders;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("====================================");
Console.WriteLine("BUILDER PATTERN DEMO");
Console.WriteLine("====================================");
Console.WriteLine("Builder est un Design Pattern de création permettant de construire progressivement un objet complexe.");
Console.WriteLine();

Console.WriteLine("1. Création du Builder");
Console.WriteLine("Création ComputerBuilder...");
var builder = new ComputerBuilder();

Console.WriteLine("\n2. Configuration des propriétés");
// Chaque méthode retourne this : les appels peuvent être enchaînés.
builder.SetCpu("Intel Core i7")
    .SetRam(32)
    .SetStorage(1000)
    .SetGpu("RTX 4070")
    .EnableWifi()
    .SetOperatingSystem("Windows 11");

Console.WriteLine("\n3. Construction de l'objet");
Console.WriteLine("Les étapes de configuration ont préparé l'ordinateur.");
Console.WriteLine("\n4. Appel de Build()");
var computer = builder.Build();
Console.WriteLine("Ordinateur créé avec succès.");

Console.WriteLine("\n5. Affichage de l'objet final");
Console.WriteLine(computer);
Console.WriteLine("\nÀ retenir : Builder = construire un objet complexe étape par étape.");
