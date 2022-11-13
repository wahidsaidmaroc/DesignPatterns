//Etape 1 :

using DependencyInjection;



/:IPiece  piece = new IPiece();

// Mais on peut
// Si je veux des commande 

BonCommande pieceCmm = new BonCommande();
pieceCmm.Total();

//Si je veux des Factures

IPiece pieceFacture = new Facture();
pieceFacture.Total();


GestionPiece gestionPiece = new GestionPiece(new BonCommande());

gestionPiece.Calculer();

GestionPiece gestionPiece1 = new GestionPiece(new Facture());

gestionPiece1.Calculer();
