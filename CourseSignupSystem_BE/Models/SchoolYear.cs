using System;
using System.Collections.Generic;

namespace CourseSignupSystem_BE.Models
{
    public partial class SchoolYear
    {
        public SchoolYear()
        {
            Classes = new HashSet<Class>();
        }

        public int SchoolYearId { get; set; }
        public string? SchoolYearName { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
