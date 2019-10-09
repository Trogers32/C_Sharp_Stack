using System.ComponentModel.DataAnnotations;
using System;
namespace CRUDelicious.Models
{
    public class User
    {
///////////////////////////////////////////////////////////////////////
        [Key]
        public int UserId { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "First name is required.")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters long.")]
        public string FirstName { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Last name is required.")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters long.")]
        public string LastName { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "An email is required.")]
        [EmailAddress(ErrorMessage = "Please provide a valid email address.")]
        public string Email { get; set; }
///////////////////////////////////////////////////////////////////////
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [Required(ErrorMessage = "A password is required."), DataType(DataType.Password)]
        public string Password { get; set; }
///////////////////////////////////////////////////////////////////////
    
        // We can provide some hardcoded default values like so:
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        // New User objects will these values assigned
    	// However, when we query existing data, CreatedAt/UpdatedAt will refer to 
    	// values that are stored in the DB
    }
} 