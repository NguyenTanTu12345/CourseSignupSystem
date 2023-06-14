using System;
using System.Collections.Generic;

namespace CourseSignupSystem_BE.Models
{
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Messagez { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
