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
        [DataType(DataType.DateTime, ErrorMessage = "An age is required.")]
        public DateTime Age { get; set; }
///////////////////////////////////////////////////////////////////////
        public int dishes { get; set; }
///////////////////////////////////////////////////////////////////////
        // We can provide some hardcoded default values like so:
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
///////////////////////////////////////////////////////////////////////
} 