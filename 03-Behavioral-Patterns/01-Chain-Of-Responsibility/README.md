# Chain of Responsibility — approbation

Chaque approbateur traite une demande ou la transmet au suivant.

## Étapes de l'exercice

1. Repérez la classe `Approver` et son lien vers le prochain maillon.
2. Examinez les montants maximums acceptés par le manager, le directeur et le comité.
3. Lancez le programme pour observer le chemin suivi par chaque demande.
4. Ajoutez un approbateur entre le directeur et le comité.
5. Testez un montant accepté par ce nouveau maillon et un montant refusé par toute la chaîne.

## Exécution

Depuis ce dossier : `dotnet run --project ChainDemo.csproj`.
