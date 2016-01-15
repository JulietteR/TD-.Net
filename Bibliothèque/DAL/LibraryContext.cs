using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Bibliothèque.Models.Stock;
using Bibliothèque.Models.Misc;

namespace Bibliothèque.DAL
{
    public class LibraryContext : DbContext
    {

        public LibraryContext() : base("LibraryContext")
        {
        }

        public DbSet<Membre> Utilisateurs { get; set; }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Emprunt> Emprunts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livre>().HasKey(t => t.ID);
            modelBuilder.Entity<Membre>().HasKey(t => t.ID);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}