using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bibliothèque.Models.Misc;

namespace Bibliothèque.Models.Stock
{
    public interface IProduit
    {
        int Id { get; }

        string Designation { get; set; }

        int Quantite { get; set; }

        double PrixUnitaireHt { get; set; }

        Tva.Taux TvaTaux { get; set; }

        string Affiche();

    }
}