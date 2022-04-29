using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstMovieGr13.Models.Database
{
    public class OrderRow
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int MovieId { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        virtual public Order Order { get; set; }

        virtual public Movie Movie { get; set; }
    }
}