using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class SaleItem
    {
        [Key]
        public int SaleId { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string SaleName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Product> Products { get; set; }
       
    }
}
