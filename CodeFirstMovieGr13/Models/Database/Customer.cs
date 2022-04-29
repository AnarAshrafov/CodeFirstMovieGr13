using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstMovieGr13.Models.Database
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required] //Not Null
        [StringLength(100)] //Nvarchar 100
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required] //Not Null
        [StringLength(100)] //Nvarchar 100
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required] //Not Null
        [StringLength(200)] //Nvarchar 100
        [Display(Name = "Billing Address")]
        public string BillingAdress { get; set; }

        [Required] //Not Null
        [StringLength(25)] //Nvarchar 100
        [Display(Name = "Billing Zip")]
        public string BillingZip { get; set; }

        [Required] //Not Null
        [StringLength(50)] //Nvarchar 100
        [Display(Name = "Billing City")]
        public string BillingCity { get; set; }

        [StringLength(200)] //Nvarchar 100
        [Display(Name = "Delivery Address")]
        public string DeliveryAdress { get; set; }

        [StringLength(25)] //Nvarchar 100
        [Display(Name = "Delivery Zip")]
        public string DeliveryZip { get; set; }

        [StringLength(50)] //Nvarchar 100
        [Display(Name = "Delivery City")]
        public string DeliveryCity { get; set; }

        [Required] //Not Null
        [StringLength(255)] //Nvarchar 100
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [StringLength(25)] //Nvarchar 100
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        virtual public ICollection<Order> Orders { get; set; }

    }
}