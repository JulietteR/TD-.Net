using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bibliothèque.Models.Stock;

namespace Bibliothèque.Models
{
    public class StockViewModel
    {
        public Stock<IProduit> Stock;

        public int TotalArticles;

        public double TotalValeur;
    }
}