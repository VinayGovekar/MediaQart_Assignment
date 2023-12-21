using MediaQart_Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace MediaQart_Assignment.Services
{
    public class UserService : IUserService
    {
      
        public string ValidateUser(User user)
        {
            var message = "";
            if (user.UserName == "") return "Name field is empty";
            else if (user.UserType == "") return "Type field is empty";
            message = ValidateUserEmail(user.Email);
            return message;
        }

        public string ValidateUserEmail(string email)
        {
            if (email == "") return "Email field is empty";
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$";

            var isValid = Regex.IsMatch(email, regex, RegexOptions.IgnoreCase);
            return isValid?"": "Email entered is not valid";
        }

        public User GetUser(UserDTO request)
        {
            if (request == null) return null;
            var user = new User()
            {
                UserName = request.UserName,
                Email = request.Email,
                UserType = request.UserType
            };
            return user;
        }
    }
}
