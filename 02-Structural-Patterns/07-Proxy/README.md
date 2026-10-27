# Proxy — image à la demande

Proxy fournit un substitut qui contrôle l'accès à un objet réel, ici en différant le chargement.

## Étapes de l'exercice

1. Repérez l'interface commune `IImage`.
2. Comparez le proxy et l'objet réel `RealImage`.
3. Exécutez le programme : le chargement n'a lieu qu'au premier affichage.
4. Appelez `Display` plusieurs fois et vérifiez qu'il n'y a qu'un chargement.
5. Ajoutez une vérification d'accès dans le proxy avant de charger l'image.

## Exécution

Depuis ce dossier : `dotnet run --project ProxyDemo.csproj`.
