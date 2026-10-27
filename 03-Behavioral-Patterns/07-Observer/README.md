# Observer — météo

Observer notifie automatiquement les abonnés lorsqu'un sujet change d'état.

## Étapes de l'exercice

1. Repérez le sujet `WeatherStation` et le contrat observateur `IWeatherObserver`.
2. Exécutez le programme et observez la notification des deux écrans.
3. Ajoutez un nouvel écran météo et abonnez-le à la station.
4. Ajoutez une méthode `Unsubscribe`.
5. Vérifiez qu'un écran désabonné ne reçoit plus les mises à jour.

## Exécution

Depuis ce dossier : `dotnet run --project ObserverDemo.csproj`.
