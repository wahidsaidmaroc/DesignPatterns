# Template Method — export de rapports

Template Method définit les grandes étapes d'un algorithme et laisse les sous-classes personnaliser certaines étapes.

## Étapes de l'exercice

1. Repérez la méthode fixe `Export` et les étapes qu'elle orchestre.
2. Comparez les formats et sauvegardes des deux exporteurs.
3. Exécutez le programme et observez que l'ordre de traitement reste identique.
4. Créez un exporteur JSON en implémentant les étapes nécessaires.
5. Ajoutez un point d'extension pour modifier la lecture des données si besoin.

## Exécution

Depuis ce dossier : `dotnet run --project TemplateMethodDemo.csproj`.
