# Mediator — petite salle de discussion

## Objectif

Dans cet exercice, deux personnes discutent dans une salle. Elles n'envoient pas
leurs messages directement l'une à l'autre : elles passent par `ChatRoom`, le
médiateur. La salle transmet chaque message à tous les membres sauf à son auteur.

## Étapes

1. **Créer le médiateur**  
   Créez une instance de `ChatRoom`. Elle sera responsable de la liste des
   participants et de la distribution des messages.

2. **Créer les participants**  
   Créez deux `ChatMember`, Alice et Bob. Donnez à chacun son nom et la salle
   de discussion. Chaque participant connaît la salle, mais ne connaît pas
   directement les autres participants.

3. **Inscrire les participants**  
   Appelez `room.Register(...)` pour ajouter Alice et Bob à la salle. Le médiateur
   pourra ainsi savoir à qui transmettre les messages.

4. **Envoyer un premier message**  
   Appelez `alice.Send("Bonjour !")`. Alice confie le message à la salle. `ChatRoom`
   le transmet à Bob, mais pas à Alice, qui en est l'expéditrice.

5. **Répondre**  
   Appelez `bob.Send("Salut Alice !")`. Cette fois, la salle transmet la réponse
   à Alice et ne la renvoie pas à Bob.

6. **Vérifier le résultat**  
   Depuis ce dossier, lancez :

   ```sh
   dotnet run --project MediatorDemo.csproj
   ```

   Vous devez obtenir :

   ```text
   Bob reçoit de Alice : Bonjour !
   Alice reçoit de Bob : Salut Alice !
   ```

## À retenir

`ChatMember` délègue l'envoi à `ChatRoom`, et `ChatRoom` coordonne les échanges.
Les participants restent ainsi indépendants les uns des autres.

## Petit défi

Ajoutez Clara : créez son participant, inscrivez-la dans la salle, puis envoyez
un message depuis Alice. Vérifiez que Bob et Clara le reçoivent, mais pas Alice.
