# Decorator — café

Decorator ajoute des options à un objet en l'enveloppant, sans modifier sa classe.

## Étapes de l'exercice

1. Repérez le contrat `ICoffee` partagé par le café et les décorateurs.
2. Exécutez la composition actuelle : café, lait puis sirop.
3. Vérifiez que la description et le prix sont enrichis à chaque étape.
4. Créez un décorateur `WhippedCreamDecorator` avec son prix.
5. Ajoutez-le à la composition et vérifiez le nouveau total.

## Exécution

Depuis ce dossier : `dotnet run --project DecoratorDemo.csproj`.
