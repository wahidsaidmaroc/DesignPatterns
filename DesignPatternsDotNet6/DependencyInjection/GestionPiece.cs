using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class GestionPiece
    {
        #region "Methode Classique"
        /// <summary>
        /// Exemple normale
        /// Mais le probleme il faut toujours passe pas Facture ou Commande pour faire le traitement
        /// </summary>
        void CalculerFacture()
        {
            Facture f = new Facture();
            f.Total();
        }
        void CalculerCommande()
        {
            BonCommande f = new BonCommande();
            f.Total();
        }
        #endregion

        #region "Exemple Dependency Injection"

        IPiece _piece;
        public GestionPiece(IPiece piece)
        {
            _piece = piece;
        }
        public void Calculer()
        {
            _piece.Total();
        }

        #endregion


    }
}
