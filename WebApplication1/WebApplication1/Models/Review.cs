using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public double Rating { get; set; }
        public DateTime Date { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}