# State — commande

State permet à un objet de modifier son comportement selon son état courant.

## Étapes de l'exercice

1. Repérez le contexte `Order`, le contrat `IOrderState` et les états concrets.
2. Exécutez le programme et suivez le passage de nouveau à expédié puis livré.
3. Vérifiez qu'une livraison répétée est traitée différemment.
4. Ajoutez un état `CancelledOrderState`.
5. Ajoutez l'action d'annulation et définissez ce qui se passe après la livraison.

## Exécution

Depuis ce dossier : `dotnet run --project StateDemo.csproj`.
