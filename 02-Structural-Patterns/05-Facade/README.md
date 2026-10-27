# Facade — cinéma maison

Facade propose une interface simple pour coordonner plusieurs composants.

## Étapes de l'exercice

1. Repérez les trois appareils qui constituent le sous-système.
2. Examinez `HomeTheaterFacade`, qui coordonne leur démarrage et leur arrêt.
3. Exécutez `WatchMovie` puis `EndMovie` et observez l'ordre des opérations.
4. Ajoutez un lecteur DVD avec ses méthodes de démarrage et d'arrêt.
5. Faites-le fonctionner depuis la façade sans exposer les détails au client.

## Exécution

Depuis ce dossier : `dotnet run --project FacadeDemo.csproj`.
