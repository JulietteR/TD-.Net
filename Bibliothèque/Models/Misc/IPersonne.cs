using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bibliothèque.Models.Misc
{
    public interface IPersonne
    {
        string Nom { get; set; }
        string Prenom { get; set; }

        string Affiche();
    }
}