// Builder est un Design Pattern de création permettant de construire progressivement un objet complexe.
using DesignPattern.Builder.Email.Builders;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("====================================");
Console.WriteLine("BUILDER PATTERN DEMO");
Console.WriteLine("====================================");
Console.WriteLine("Builder est un Design Pattern de création permettant de construire progressivement un objet complexe.");
Console.WriteLine();

Console.WriteLine("1. Création du Builder");
Console.WriteLine("Création EmailBuilder...");
var builder = new EmailBuilder();

Console.WriteLine("\n2. Configuration des propriétés");
// Les noms des méthodes rendent la chaîne de configuration lisible.
builder.From("contact@company.com")
    .To("client@company.com")
    .Subject("Votre commande")
    .Body("Votre commande est disponible.")
    .AddAttachment("facture.pdf")
    .SetPriority("High")
    .Cc("support@company.com");

Console.WriteLine("\n3. Construction de l'objet");
Console.WriteLine("Les étapes de configuration ont préparé l'email, sans l'envoyer.");
Console.WriteLine("\n4. Appel de Build()");
var email = builder.Build();
Console.WriteLine("Email créé avec succès.");

Console.WriteLine("\n5. Affichage de l'objet final");
Console.WriteLine(email);
Console.WriteLine("\nÀ retenir : Builder = construire un objet complexe étape par étape.");
