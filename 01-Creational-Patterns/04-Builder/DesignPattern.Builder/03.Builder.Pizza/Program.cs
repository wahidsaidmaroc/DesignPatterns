// Builder est un Design Pattern de création permettant de construire progressivement un objet complexe.
using DesignPattern.Builder.Pizza.Builders;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("====================================");
Console.WriteLine("BUILDER PATTERN DEMO");
Console.WriteLine("====================================");
Console.WriteLine("Builder est un Design Pattern de création permettant de construire progressivement un objet complexe.");
Console.WriteLine();

Console.WriteLine("1. Création du Builder");
Console.WriteLine("Création PizzaBuilder...");
var builder = new PizzaBuilder();

Console.WriteLine("\n2. Configuration des propriétés");
// Les ingrédients sont optionnels : sans AddChicken(), Chicken reste false.
builder.SetSize("Large")
    .AddCheese()
    .AddTomato()
    .AddOlives()
    .AddMushrooms();

Console.WriteLine("\n3. Construction de l'objet");
Console.WriteLine("Les étapes de configuration ont préparé la pizza.");
Console.WriteLine("\n4. Appel de Build()");
var pizza = builder.Build();
Console.WriteLine("Pizza créée avec succès.");

Console.WriteLine("\n5. Affichage de l'objet final");
Console.WriteLine(pizza);
Console.WriteLine("\nÀ retenir : Builder = construire un objet complexe étape par étape.");
