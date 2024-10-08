// Models/User.cs
namespace TigerTix.Web.Models
{
    public class User
    {
        public string Username { get; set; }    // User's username
        public string Password { get; set; }    // User's password
        public string FullName { get; set; }    // User's full name
        public string Email { get; set; }       // User's email address
    }
}