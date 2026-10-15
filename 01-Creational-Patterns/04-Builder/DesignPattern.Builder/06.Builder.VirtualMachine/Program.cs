// Builder est un Design Pattern de création permettant de construire progressivement un objet complexe.
using DesignPattern.Builder.VirtualMachine.Builders;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("====================================");
Console.WriteLine("BUILDER PATTERN DEMO");
Console.WriteLine("====================================");
Console.WriteLine("Builder est un Design Pattern de création permettant de construire progressivement un objet complexe.");
Console.WriteLine();

Console.WriteLine("1. Création du Builder");
Console.WriteLine("Création VirtualMachineBuilder...");
var builder = new VirtualMachineBuilder();

Console.WriteLine("\n2. Configuration des propriétés");
// Le Builder décrit la VM souhaitée ; il ne crée aucune ressource dans le cloud.
builder.SetName("WebServer01")
    .SetCpu(4)
    .SetRam(16)
    .SetStorage(512)
    .SetOperatingSystem("Linux")
    .SetRegion("West Europe")
    .EnablePublicIp()
    .EnableBackup();

Console.WriteLine("\n3. Construction de l'objet");
Console.WriteLine("Les étapes de configuration ont préparé la machine virtuelle.");
Console.WriteLine("\n4. Appel de Build()");
var vm = builder.Build();
Console.WriteLine("Virtual Machine créée avec succès.");

Console.WriteLine("\n5. Affichage de l'objet final");
Console.WriteLine(vm);
Console.WriteLine("\nÀ retenir : Builder = construire un objet complexe étape par étape.");
