# Flyweight — styles de caractères

Flyweight partage les données communes afin d'éviter de créer plusieurs fois les mêmes objets.

## Étapes de l'exercice

1. Distinguez le caractère individuel des données de style partagées.
2. Observez comment `CharacterStyleFactory` réutilise un style existant.
3. Exécutez le programme : trois caractères utilisent seulement deux styles.
4. Ajoutez plusieurs caractères avec le même style et vérifiez que le nombre de styles ne change pas.
5. Ajoutez une couleur au style et à sa clé de partage.

## Exécution

Depuis ce dossier : `dotnet run --project FlyweightDemo.csproj`.
