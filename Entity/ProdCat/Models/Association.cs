using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ProdCat.Models
{
    public class Associations
    {
///////////////////////////////////////////////////////////////////////
        [Key]
        public int AssociationId { get; set; }
///////////////////////////////////////////////////////////////////////
        public int ProductId { get; set; }
///////////////////////////////////////////////////////////////////////
        public int CategoryId { get; set; }
///////////////////////////////////////////////////////////////////////
        public Product Product {get;set;}
        public Category Category {get;set;}
///////////////////////////////////////////////////////////////////////
        // We can provide some hardcoded default values like so:
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}
