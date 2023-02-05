// See https://aka.ms/new-console-template for more information
using Singleton;
using System.Net.WebSockets;

Console.WriteLine("Hello, World!");


ClientService clientService = new ClientService();

clientService.AjouterClient();
clientService.AjouterClient();

FournisseurService fournisseurService = new FournisseurService();

fournisseurService.AjouterFournisseur();