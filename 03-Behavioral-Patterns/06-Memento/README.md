# Memento — éditeur de texte

Memento sauvegarde et restaure l'état d'un objet sans exposer ses détails internes.

## Étapes de l'exercice

1. Repérez l'état privé de `TextEditor` et l'objet `EditorMemento`.
2. Exécutez le programme pour sauvegarder, modifier puis restaurer le texte.
3. Vérifiez que le memento contient l'état au moment de la sauvegarde.
4. Stockez plusieurs mementos dans une pile.
5. Ajoutez une action « annuler » qui restaure le dernier état enregistré.

## Exécution

Depuis ce dossier : `dotnet run --project MementoDemo.csproj`.
