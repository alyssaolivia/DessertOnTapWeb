using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DessertOnTapWeb.Models
{
    public enum PaymentMethod{
        CreditCard,
        DebitCard,
        Cash,
        BankTransfer,
        Mixed,
        GiftCard
    }
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("Customer.ID")]
        public int CustomerID { get; set; }
        //public  Address { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string PaymentNote { get; set; }
        public bool Paid { get; set; }
    }
}