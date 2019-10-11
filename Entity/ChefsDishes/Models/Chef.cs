using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefsDishes.Models
{
    public class Chef
    {
///////////////////////////////////////////////////////////////////////
        [Key]
        public int ChefId { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "First name is required.")]
        [MinLength(2, ErrorMessage = "First name must be more than 2 characters long.")]
        public string FName { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Last name is required.")]
        [MinLength(2, ErrorMessage = "Last name must be more than 2 characters long.")]
        public string LName { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "An age is required.")]
        public DateTime Age { get; set; }
///////////////////////////////////////////////////////////////////////
        // We can provide some hardcoded default values like so:
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
///////////////////////////////////////////////////////////////////////
/////// ///////////////////////////////////////////////////////////////
    public class Dish
    {
///////////////////////////////////////////////////////////////////////
        [Key]
        public int DishId { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(45, ErrorMessage = "Name must be less than 45 characters long.")]
        public string Name { get; set; }
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
        public int ChefId { get; set; }
        public Chef Creator {get; set;}
    
        // We can provide some hardcoded default values like so:
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
} 