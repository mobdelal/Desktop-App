using E_commerce.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace E_Commerce.DTO.user
{
    public class UserDTO
    {

        public int UserId { get; set; }
        public string Username { get; set; }
        public  string Password { get; set; }   
        
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public Flag Role { get; set; }


    }
}
