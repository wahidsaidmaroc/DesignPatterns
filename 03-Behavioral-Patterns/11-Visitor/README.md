# Visitor — aire des formes

Visitor ajoute une opération aux éléments d'une structure sans placer son calcul dans chaque élément.

## Étapes de l'exercice

1. Repérez les éléments `Circle` et `Rectangle`, ainsi que le contrat `IShapeVisitor`.
2. Suivez l'appel double-dispatch de `Accept` à `Visit`.
3. Exécutez le calcul des aires fourni par `AreaVisitor`.
4. Ajoutez un visiteur qui calcule le périmètre des formes.
5. Ajoutez une forme et implémentez sa visite pour les deux opérations.

## Exécution

Depuis ce dossier : `dotnet run --project VisitorDemo.csproj`.
