using System;
using System.ComponentModel.DataAnnotations; 

namespace QuotingDojo.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}