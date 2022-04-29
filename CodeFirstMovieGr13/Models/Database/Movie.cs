using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstMovieGr13.Models.Database
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Director { get; set; }

        [Required]
        [Range(1920,2050)]
        public int ReleaseYear { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        virtual public ICollection<OrderRow> OrderRows { get; set; }

    }
}