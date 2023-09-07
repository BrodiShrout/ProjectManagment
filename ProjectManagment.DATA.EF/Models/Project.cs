using System;
using System.Collections.Generic;

namespace ProjectManagment.DATA.EF.Models
{
    public partial class Project
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; } = null!;
        public int ProjectNumber { get; set; }
        public string ProjectCity { get; set; } = null!;
        public string ProjectState { get; set; } = null!;
        public int EmployeeId { get; set; }
        public int ProjectManagerId { get; set; }
        public string? ExelSheet { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual ProjectManager? ProjectManager { get; set; }
    }
}
