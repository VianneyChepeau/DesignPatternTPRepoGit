using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP.BAD
{
    interface IAmiFacebook
    {
        // des elements commun avec IPersonne => nouvelle interface ?

        int Age { get; }
        DateTime DateDeNaissance { get; set; }
        void EnvoyerMessage(string msg);

        // ici, nous avons le pseudo, pas forcément le nom complet
        string Pseudo { get; set; }
        int Mail { get; set; }
    }
}
