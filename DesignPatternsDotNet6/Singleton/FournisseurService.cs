using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class FournisseurService
    {
        public void AjouterFournisseur()
        {
            ActionHelper.GetInstance.AjouterAction();
        }
    }
}
