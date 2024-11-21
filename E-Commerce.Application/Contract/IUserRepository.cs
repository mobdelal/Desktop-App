using E_commerce.Model;
using E_Commerce.DTO.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Contract
{
    public interface IUserRepository :IGenaricrepository<User>
    {
        User GetUserById(int userId);
        void AddUser(User user);
        bool Authenticate(string username, string password);
         User GetUserByUsernameAndPassword(string username, string password);

    }
}
