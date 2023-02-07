﻿using System;
using System.Collections.Generic;

namespace SchoolProject.Entities
{
    public partial class Project
    {
        public int Id { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
    }
}
