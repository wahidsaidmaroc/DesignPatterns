# Mediator — petite salle de discussion

## Objectif

On veut permettre à plusieurs personnes de discuter sans que chacune ait à
connaître directement toutes les autres. Une salle de discussion, `ChatRoom`,
joue le rôle de médiateur : les participants lui confient leurs messages, puis
elle les transmet aux autres participants.

À la fin de l'exercice, vous saurez expliquer le rôle de `ChatRoom`, de
`ChatMember` et le trajet d'un message.

## Le scénario

Alice et Bob sont inscrits dans la même salle :

1. Alice envoie « Bonjour ! » à la salle.
2. La salle transmet le message à Bob, mais pas à Alice.
3. Bob répond « Salut Alice ! » à la salle.
4. La salle transmet la réponse à Alice, mais pas à Bob.

## Étapes détaillées

### 1. Repérer le code client

Ouvrez `Program.cs` et commencez par lire les premières lignes :

```csharp
var room = new ChatRoom();
var alice = new ChatMember("Alice", room);
var bob = new ChatMember("Bob", room);
```

- `room` est la salle qui coordonne les échanges.
- `alice` et `bob` sont les participants.
- La salle est passée à chaque participant lors de sa création. Ainsi, chaque
  participant peut envoyer un message à la salle sans avoir de référence directe
  vers les autres.

**À vérifier :** Alice et Bob reçoivent-ils l'un l'autre dans leur constructeur ?
Non : ils connaissent `room`, pas le nom ou l'objet de l'autre participant.

### 2. Inscrire les participants

Juste après leur création, le programme appelle :

```csharp
room.Register(alice);
room.Register(bob);
```

Dans `ChatRoom`, repérez la liste des membres et la méthode `Register` :

```csharp
private readonly List<ChatMember> _members = [];

public void Register(ChatMember member) => _members.Add(member);
```

La liste `_members` garde les participants inscrits. `Register` ajoute un membre
à cette liste. Sans cette inscription, la salle ne saurait pas à qui transmettre
les messages.

**À faire :** comptez les appels à `Register` dans le programme. Combien de
participants la salle peut-elle contacter dans cet exemple ?

### 3. Suivre l'envoi d'Alice

Le programme demande ensuite à Alice d'envoyer un message :

```csharp
alice.Send("Bonjour !");
```

Repérez la méthode `Send` de `ChatMember` :

```csharp
public void Send(string message) => room.Send(message, this);
```

Alice ne choisit pas elle-même un destinataire. Elle transmet le texte à `room`
et passe aussi `this`, c'est-à-dire sa propre instance, pour indiquer qui a
envoyé le message.

**À faire :** identifiez les deux informations transmises à la salle : le texte
du message et l'expéditeur.

### 4. Comprendre la distribution par la salle

Dans `ChatRoom`, l'autre méthode `Send` parcourt la liste des inscrits :

```csharp
public void Send(string message, ChatMember sender)
{
    foreach (var member in _members.Where(member => member != sender))
    {
        member.Receive(message, sender.Name);
    }
}
```

- `foreach` examine chaque membre inscrit.
- `member != sender` écarte l'expéditeur : Alice ne reçoit donc pas son propre
  message.
- `Receive` transmet le texte au membre destinataire et lui indique le nom de
  l'expéditeur.

Pour le message d'Alice, la salle examine Alice puis Bob. Alice est ignorée,
tandis que Bob reçoit « Bonjour ! ».

### 5. Voir comment un participant reçoit un message

Repérez `Receive` dans `ChatMember` :

```csharp
public void Receive(string message, string sender) =>
    Console.WriteLine($"{Name} reçoit de {sender} : {message}");
```

Cette méthode affiche le nom du participant qui reçoit le message, le nom de
l'expéditeur et le texte reçu. Elle n'envoie pas de message à son tour : c'est
le code client qui demande ensuite à Bob de répondre.

### 6. Suivre la réponse de Bob

La ligne suivante déclenche la réponse :

```csharp
bob.Send("Salut Alice !");
```

Le même chemin est suivi : Bob appelle `room.Send(...)`, puis la salle distribue
le message à tous les membres sauf Bob. Alice reçoit donc la réponse.

**À faire :** retracez les appels dans l'ordre pour la réponse :
`ChatMember.Send` → `ChatRoom.Send` → `ChatMember.Receive`.

### 7. Exécuter et comparer le résultat

Depuis le dossier `05-Mediator`, lancez :

```sh
dotnet run --project MediatorDemo.csproj
```

Le résultat attendu est :

```text
Bob reçoit de Alice : Bonjour !
Alice reçoit de Bob : Salut Alice !
```

Vérifiez que chaque message apparaît une seule fois et que son expéditeur ne le
reçoit pas.

## Petit défi : ajouter Clara

1. Après la création d'Alice et Bob, créez Clara en lui passant la même salle :
   `var clara = new ChatMember("Clara", room);`
2. Inscrivez Clara avec `room.Register(clara);`.
3. Relancez le programme : Clara doit recevoir le message d'Alice et celui de
   Bob.
4. Ajoutez `clara.Send("Bonjour à tous !");`.
5. Vérifiez que la salle transmet ce nouveau message à Alice et Bob, mais pas à
   Clara.

## À retenir

Sans Mediator, les participants devraient gérer eux-mêmes les communications
avec les autres. Ici, `ChatMember` communique avec `ChatRoom`, et `ChatRoom`
coordonne la distribution. Les participants ne dépendent donc pas directement
les uns des autres.
