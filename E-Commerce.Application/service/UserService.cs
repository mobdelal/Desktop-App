using AutoMapper;
using E_commerce.Model;
using E_Commerce.Application.Contract;
using E_Commerce.DTO.user;
using System.Text.RegularExpressions;

namespace E_Commerce.Application.service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository , IMapper _mapper)
        {
            _userRepository = userRepository;
            mapper = _mapper;
        }

        public UserDTO GetUserById(int userId)
        {
            var user = _userRepository.GetUserById(userId);
            if (user != null)
            {
                return new UserDTO
                {
                    UserId = user.UserID,
                    Username = user.Username,
                    Role = user.Role,
                    Password = user.Password
                };
            }
            else
            {
                return null; 
            }
        }

        public void CreateUser(UserDTO userDto)
        {
            if (!IsValidUsername(userDto.Username))
            {
                throw new ArgumentException("Invalid username.");
            }

            if (!IsValidEmail(userDto.Email))
            {
                throw new ArgumentException("Invalid email.");
            }

            if (!IsValidPassword(userDto.Password))
            {
                throw new ArgumentException("Invalid password.");
            }

            if (!IsValidPhoneNumber(userDto.PhoneNumber))
            {
                throw new ArgumentException("Invalid phone number.");
            }

          

            User user = mapper.Map<User>(userDto);


            _userRepository.AddUser(user);
        }

        private bool IsValidUsername(string username)
        {
           
            return !string.IsNullOrEmpty(username) && username.Length >= 3 && username.Length <= 20 && username.All(char.IsLetterOrDigit);
        }

        private bool IsValidEmail(string email)
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private bool IsValidPassword(string password)
        {
            var passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            var phonePattern = @"^\d{11}$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }



      
        public UserDTO AuthenticateUser(string username, string password)
        {
            var user = _userRepository.GetUserByUsernameAndPassword(username, password);

            if (user != null)
            {
                return new UserDTO
                {
                    UserId = user.UserID,
                    Username = user.Username,
                    Role = user.Role, 
                };
            }

            return null; 
        }

    }
}
