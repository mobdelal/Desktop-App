using E_commerce.Model;
using E_Commerce.Application.Contract;
using E_Commerce.Context;
using E_Commerce.DTO.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure
{
    public class UserRepository: GenaricRepository<User> , IUserRepository
    {
        private readonly EContext _context;

        public UserRepository(EContext context):base(context) 
        {
            _context = context;
        }


   

        public User GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public bool Authenticate(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            return user != null;
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {

            return _context.Users
                           .FirstOrDefault(u => u.Username == username && u.Password == password);
        }
    }
}
