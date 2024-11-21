using E_commerce.Model;
using E_Commerce.DTO.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace E_Commerce.Application.service
{
    public interface IUserService
{
        UserDTO GetUserById(int userId);
        void CreateUser(UserDTO userDto);
         UserDTO AuthenticateUser(string username, string password);


    }
}
