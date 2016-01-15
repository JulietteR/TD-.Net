using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Bibliothèque.Models.Misc;
using Bibliothèque.Models.Stock;
using Bibliothèque.Models.Outils;

namespace Bibliothèque.DAL
{
    public class LibraryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var utilisateurs = new List<Membre>
            {
                new Membre { username="Jean", password="azerty" },
                new Membre { username="Meredith",password="qsdfgh"},
                new Membre { username="Arturo", password="wxcvb"}
            };

            utilisateurs.ForEach(s => context.Utilisateurs.Add(s));
            context.SaveChanges();

            var livres = new List<Livre>
            {
                new Livre { Designation="Eragon", Auteur=new PersonneBase("Pauolini", "Christopher"), Editeur= "inconnu" },
                new Livre { Designation ="Promesse - La sixième enquête du Département V", Auteur=new PersonneBase("Jussi", "Adler-Olsen"), Editeur= "inconnu" },
                new Livre { Designation ="Désaxé", Auteur = new PersonneBase("Lars", "Kepler"), Editeur= "inconnu" }
            };

            livres.ForEach(s => context.Livres.Add(s));
            context.SaveChanges();

            var emprunts = new List<Emprunt>
            {
                new Emprunt {livreID=0, membreID=1, dateFin=DateTime.Parse("20016-01-15") },
                new Emprunt {livreID=1, membreID=2, dateFin=DateTime.Parse("20016-02-17") },
                new Emprunt {livreID=2, membreID=0, dateFin=DateTime.Parse("20016-08-18") },
            };

            emprunts.ForEach(s => context.Emprunts.Add(s));
            context.SaveChanges();
        }
    }
}