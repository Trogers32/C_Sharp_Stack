using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; ////allows model validation

namespace CRUDelicious.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; } 

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}