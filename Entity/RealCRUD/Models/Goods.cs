using System.ComponentModel.DataAnnotations;
using System;
namespace RealCRUD.Models
{
    public class Good
    {
///////////////////////////////////////////////////////////////////////
        [Key]
        public int Id { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(45, ErrorMessage = "Name must be less than 45 characters long.")]
        public string Name { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Chef is required.")]
        [StringLength(45, ErrorMessage = "Chef must be less than 45 characters long.")]
        public string Chef { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Tastiness is required.")]
        [Range(1,5, ErrorMessage = "Tastiness must be between 1 and 5.")]
        public int Tastiness{get;set;}
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Calories is required.")]
        [Range(1,int.MaxValue, ErrorMessage = "Calories must be greater than 0.")]
        public int Calories{get;set;}
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }
///////////////////////////////////////////////////////////////////////
    
        // We can provide some hardcoded default values like so:
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        // New User objects will these values assigned
    	// However, when we query existing data, CreatedAt/UpdatedAt will refer to 
    	// values that are stored in the DB
    }
} 