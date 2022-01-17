using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DessertOnTapWeb.Models
{
    public class Item
    {
        public int ID {get; set;}  
        public string Name {get; set;}
        public string Unit { get; set; }
        public decimal Price {get; set;}
        public string ImageLink { get; set; }
        public bool Display { get; set; }
        public bool Taxable { get; set; }
    }
}