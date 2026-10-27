# Adapter — paiement

L'Adapter traduit l'interface attendue par l'application vers celle d'un ancien service.

## Étapes de l'exercice

1. Repérez l'interface `IPaymentProcessor` utilisée par le client.
2. Examinez `OldPaymentService`, qui expose une méthode différente et reçoit un `double`.
3. Implémentez `OldPaymentAdapter` pour convertir l'appel et le montant.
4. Lancez le programme et vérifiez que le paiement est transmis à l'ancien service.
5. Ajoutez un deuxième ancien service et écrivez un autre adaptateur sans modifier le client.

## Exécution

Depuis ce dossier : `dotnet run --project AdapterDemo.csproj`.
