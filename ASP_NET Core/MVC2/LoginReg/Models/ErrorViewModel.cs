using System;
using System.ComponentModel.DataAnnotations; 
using System.Collections.Generic;

namespace LoginReg.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class User
    {
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "First name is required.")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters long.")]
        public string Firstname {get;set;}
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "Last name is required.")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters long.")]
        public string Lastname {get;set;}
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "An email is required.")]
        [EmailAddress(ErrorMessage = "Please provide a valid email address.")]
        public string Email {get;set;}
///////////////////////////////////////////////////////////////////////
        [Required(ErrorMessage = "A password is required.")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
///////////////////////////////////////////////////////////////////////
    }
    public class IndexViewModel{
        public User newUser {get;set;}
    }
}