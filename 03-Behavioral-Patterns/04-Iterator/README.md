# Iterator — collection de livres

Iterator permet de parcourir une collection sans exposer la façon dont elle stocke ses éléments.

## Étapes de l'exercice

1. Repérez `BookCollection` et son stockage interne.
2. Identifiez l'implémentation de `IEnumerable<Book>` et de son énumérateur.
3. Exécutez le `foreach` sans accéder à la liste interne.
4. Ajoutez une méthode qui retourne les livres dans l'ordre inverse.
5. Parcourez ce nouvel ordre sans modifier le code client.

## Exécution

Depuis ce dossier : `dotnet run --project IteratorDemo.csproj`.
