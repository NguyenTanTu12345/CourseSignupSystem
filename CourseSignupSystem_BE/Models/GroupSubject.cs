using System;
using System.Collections.Generic;

namespace CourseSignupSystem_BE.Models
{
    public partial class GroupSubject
    {
        public GroupSubject()
        {
            Subjects = new HashSet<Subject>();
        }

        public int GroupSubjectId { get; set; }
        public string? GroupSubjectName { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
