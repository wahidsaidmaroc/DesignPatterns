# Strategy — livraison

Strategy permet de remplacer un algorithme sans changer le code qui l'utilise.

## Étapes de l'exercice

1. Repérez le contrat `IDeliveryStrategy` et les stratégies concrètes.
2. Exécutez le calcul avec la livraison standard puis express.
3. Comparez les tarifs appliqués au même poids.
4. Créez une stratégie de livraison gratuite au-delà d'un poids ou d'un montant donné.
5. Utilisez cette stratégie depuis `Checkout` sans modifier sa méthode de calcul.

## Exécution

Depuis ce dossier : `dotnet run --project StrategyDemo.csproj`.
