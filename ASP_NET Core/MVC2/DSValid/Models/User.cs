using System;
using System.ComponentModel.DataAnnotations;

namespace DSValid.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class User
    {
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Name is required")]
        [MinLength(2, ErrorMessage = "Name must be 2 or more")]
        public string Username {get;set;}
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Favorite Language is required")]
        public string Language {get;set;}
///////////////////////////////////////////////////////////////////////
        [MaxLength(20, ErrorMessage = "Comment must be less than 20")]
        public string Comment {get;set;}
///////////////////////////////////////////////////////////////////////
    }
    public class IndexViewModel{
        public User newUser {get;set;}
    }
}