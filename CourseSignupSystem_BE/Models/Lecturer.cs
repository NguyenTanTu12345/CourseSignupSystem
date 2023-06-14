using System;
using System.Collections.Generic;

namespace CourseSignupSystem_BE.Models
{
    public partial class Lecturer
    {
        public int LecturerId { get; set; }
        public string? TaxCode { get; set; }
        public string? LecturerPassword { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? LecturerAddress { get; set; }
        public string? ImagePath { get; set; }
        public string? MainSubject { get; set; }
        public string? SubSubject { get; set; }
    }
}
