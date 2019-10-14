using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProdCat.Models
{
    public class Product
    {
///////////////////////////////////////////////////////////////////////
        [Key]
        public int ProductId { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Name is required.")]
        [MinLength(2, ErrorMessage = "Name must be more than 2 characters long.")]
        public string Name { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Price is required.")]
        public Decimal Price { get; set; }
///////////////////////////////////////////////////////////////////////
        // We can provide some hardcoded default values like so:
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
///////////////////////////////////////////////////////////////////////
    public List<Associations> Categories {get;set;}
    }
}
