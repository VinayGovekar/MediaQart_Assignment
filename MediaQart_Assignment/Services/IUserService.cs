using MediaQart_Assignment.Models;

namespace MediaQart_Assignment.Services
{
    public interface IUserService
    {
        public string ValidateUser(User user);
        public User GetUser(UserDTO request);
    }
}
