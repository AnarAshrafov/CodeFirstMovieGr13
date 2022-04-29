using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstMovieGr13.Models.Database
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime OrderDate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal OrderSum { get; set; }

        public int CustomerId { get; set; }

        virtual public Customer Customer { get; set; }

        virtual public ICollection<OrderRow> OrderRows { get; set; }

    }
}