using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bibliothèque.Models.Misc
{
    public class Membre
    {
        [Key]
        public int ID { get; set; }
        public string username { get; set; }
        public string  password { get; set; }

        public string Affiche()
        {
            return System.String.Format("{0}, {1}", username, password);
        }
    }
}