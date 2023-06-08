using System;
using System.Collections.Generic;

namespace CourseSignupSystem_BE.Models
{
    public partial class Student
    {
        public string StudentId { get; set; } = null!;
        public string? StudentPassword { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? StudentAddress { get; set; }
        public string? Parent { get; set; }
        public string? ImagePath { get; set; }
    }
}
