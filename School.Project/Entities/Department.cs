using System;
using System.Collections.Generic;

namespace SchoolProject.Entities
{
    public partial class Department
    {
        public Department()
        {
            Projects = new HashSet<Project>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
