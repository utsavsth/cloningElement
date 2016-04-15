using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CloningElements.Models
{
    public class Gift
    {
        [Required]
        public string Name { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a price above zero.")]
        public double Price { get; set; }
    }
}