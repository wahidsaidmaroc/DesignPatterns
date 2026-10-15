// Builder est un Design Pattern de création permettant de construire progressivement un objet complexe.
using DesignPattern.Builder.Order.Builders;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("====================================");
Console.WriteLine("BUILDER PATTERN DEMO");
Console.WriteLine("====================================");
Console.WriteLine("Builder est un Design Pattern de création permettant de construire progressivement un objet complexe.");
Console.WriteLine();

Console.WriteLine("1. Création du Builder");
Console.WriteLine("Création OrderBuilder...");
var builder = new OrderBuilder();

Console.WriteLine("\n2. Configuration des propriétés");
// AddProduct peut être appelé plusieurs fois pour enrichir la même commande.
builder.SetClient("Client 001")
    .AddProduct("Laptop", 1)
    .AddProduct("Mouse", 2)
    .SetDelivery("Express")
    .SetPayment("Card")
    .SetDiscount(10)
    .SetDeliveryAddress("10 rue des Fleurs, Casablanca");

Console.WriteLine("\n3. Construction de l'objet");
Console.WriteLine("Les étapes de configuration ont préparé la commande.");
Console.WriteLine("\n4. Appel de Build()");
var order = builder.Build();
Console.WriteLine("Commande créée avec succès.");

Console.WriteLine("\n5. Affichage de l'objet final");
Console.WriteLine(order);
Console.WriteLine("\nÀ retenir : Builder = construire un objet complexe étape par étape.");
