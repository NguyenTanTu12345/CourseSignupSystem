using System;
using System.Collections.Generic;

namespace CourseSignupSystem_BE.Models
{
    public partial class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public string? FacultyName { get; set; }
        public int? GroupSubjectId { get; set; }

        public virtual GroupSubject? GroupSubject { get; set; }
    }
}
