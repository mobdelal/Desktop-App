using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Model
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public int UnitsInStock { get; set; }
        public bool Discount { get; set; }

        // Navigation Properties
        public Categoryy Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
