# Bridge — messages

Le Bridge sépare le type de message de son moyen d'envoi : les deux hiérarchies peuvent évoluer indépendamment.

## Étapes de l'exercice

1. Identifiez l'abstraction `Message` et l'implémentation `IMessageSender`.
2. Observez les deux types de message et les deux canaux d'envoi.
3. Exécutez le programme pour voir les combinaisons alerte/e-mail et rappel/SMS.
4. Ajoutez un nouveau canal, par exemple une notification push, sans modifier `Alert` ni `Reminder`.
5. Testez ce canal avec les deux types de message.

## Exécution

Depuis ce dossier : `dotnet run --project BridgeDemo.csproj`.
