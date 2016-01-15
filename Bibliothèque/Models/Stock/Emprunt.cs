using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bibliothèque.Models;
using Bibliothèque.Models.Misc;

namespace Bibliothèque.Models.Stock
{
    public class Emprunt
    {
        public int livreID { get; set; }
        public int membreID { get; set; }
        public DateTime dateFin { get; set; }
    }
}