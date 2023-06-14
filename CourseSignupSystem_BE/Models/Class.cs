using System;
using System.Collections.Generic;

namespace CourseSignupSystem_BE.Models
{
    public partial class Class
    {
        public Class()
        {
            ClassStudents = new HashSet<ClassStudent>();
        }

        public int ClassId { get; set; }
        public string? ClassName { get; set; }
        public int? Quantity { get; set; }
        public bool? Statez { get; set; }
        public double? Tuition { get; set; }
        public string? Descriptionz { get; set; }
        public string? ImagePath { get; set; }
        public DateTime? DateStart { get; set; }
        public string? FacultyName { get; set; }
        public int? SchoolYearId { get; set; }

        public virtual SchoolYear? SchoolYear { get; set; }
        public virtual ICollection<ClassStudent> ClassStudents { get; set; }
    }
}
