using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProdCat.Models
{
    public class Category
    {
///////////////////////////////////////////////////////////////////////
        [Key]
        public int CategoryId { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Name is required.")]
        [MinLength(2, ErrorMessage = "Name must be more than 2 characters long.")]
        public string Name { get; set; }
///////////////////////////////////////////////////////////////////////
        // We can provide some hardcoded default values like so:
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
///////////////////////////////////////////////////////////////////////
        public List<Associations> Products {get;set;}
    }
}
