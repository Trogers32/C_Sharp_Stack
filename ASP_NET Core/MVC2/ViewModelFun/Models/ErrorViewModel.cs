
using System.Collections.Generic;
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ViewModelFun.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class User
    {
        [Required(ErrorMessage = "Username is required")]
        [MinLength(3, ErrorMessage = "Email must be 3 or more")]
        public string Username {get;set;}
 
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class Intro{
        public string desc {get;set;}
    }
}