using System;
using System.Collections.Generic;

namespace ProjectManagment.DATA.EF.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Projects = new HashSet<Project>();
        }

        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public virtual ICollection<Project> Projects { get; set; }
    }
}
