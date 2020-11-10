using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        [Key][Required]
        public int ProductId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public string Photo { get; set; }
        [Required]
        public double Price { get; set; }
        public double Discount { get; set; }
        public double Rating { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}