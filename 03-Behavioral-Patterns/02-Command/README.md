# Command — télécommande

Command transforme une action en objet, que l'on peut exécuter et annuler.

## Étapes de l'exercice

1. Repérez le contrat `ICommand`, la lampe et la télécommande.
2. Suivez comment `TurnOnCommand` encapsule les actions d'allumage et d'annulation.
3. Exécutez le programme et observez l'allumage puis l'extinction.
4. Créez une commande `TurnOffCommand`.
5. Ajoutez une commande à la télécommande et vérifiez que son annulation restaure l'état précédent.

## Exécution

Depuis ce dossier : `dotnet run --project CommandDemo.csproj`.
