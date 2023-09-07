using System;
using System.Collections.Generic;

namespace ProjectManagment.DATA.EF.Models
{
    public partial class ProjectManager
    {
        public ProjectManager()
        {
            Projects = new HashSet<Project>();
        }

        public int ProjectManagerId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual ICollection<Project> Projects { get; set; }
    }
}
