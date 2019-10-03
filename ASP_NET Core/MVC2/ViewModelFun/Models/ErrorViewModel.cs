
using System.Collections.Generic;
using System;
using System.Collections;

namespace ViewModelFun.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class User
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
    }
    public class Intro{
        public string desc {get;set;}
    }
}