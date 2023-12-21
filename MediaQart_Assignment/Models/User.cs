using System.Text.Json.Serialization;

namespace MediaQart_Assignment.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        = string.Empty;
        public string Email { get; set; }
        
        public string UserType { get; set; }
    }
}
