using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ActionHelper
    {
        int a=0;


        private static ActionHelper instance = null;
        public static ActionHelper GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new ActionHelper();
                return instance;
            }
        }


        public void AjouterAction()
        {
            a++;
            Console.WriteLine($"Action Ajouter Helper {a}");
        }
    }
}
