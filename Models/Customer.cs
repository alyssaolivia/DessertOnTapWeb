using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace DessertOnTapWeb.Models
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public Address Address { get; set; }
        public DateTime DateOfBirth {get;set;}
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Home_PhoneNumber { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Work_PhoneNumber { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Cell_PhoneNumber { get; set; }
    }
}