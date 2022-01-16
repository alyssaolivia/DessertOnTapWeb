using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DessertOnTapWeb.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("Customer.ID")]
        public int ClientID { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
    }
}