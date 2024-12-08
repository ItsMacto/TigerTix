// Models/User.cs
using System.ComponentModel.DataAnnotations;
namespace TigerTix.Web.Models

{
    public class User
    {
        public int Id { get; set; }             // Primary key
        public string Username { get; set; } = null!;   // User's username
        public string Password { get; set; } = null!;  // User's password
        public string FullName { get; set; } = null!;   // User's full name
        public string Email { get; set; } = null!;      // User's email address

        public bool IsStudentAccount { get; set; } // Indicates if the account is a student account
        
        [RegularExpression(@"(^C\d{8}$)|(^$)", ErrorMessage = "CUID should start with 'C' followed by 8 digits.")]
        public string? CUID { get; set; }       // User's CUID if they are a student
    }
}