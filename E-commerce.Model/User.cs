using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Model
{
    public enum Flag
    {
        Admin =1 ,
        Customer =2
    }

    public enum OrderStatus
    {
        Processing,
        Shipped,
        Delivered
    }
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        [MaxLength(255)]

        public string Username { get; set; }
        [Required]
        [MaxLength(255)]
        [DataType(DataType.Password)]
        public required string Password { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        public Flag Role { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
