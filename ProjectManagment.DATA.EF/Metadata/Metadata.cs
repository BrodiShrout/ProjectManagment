using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectManagment.DATA.EF/*.Metadata*/
{
    #region Projects
    public class ProjectMetadata
    {
        public int ProjectId { get; set; }

        [Required(ErrorMessage = "Project Name is required")]
        [StringLength(500, ErrorMessage = "Project Name cannot exceed 500 characters")]
        [Display(Name = "Project Name")]
        public string ProName { get; set; } = null!;

        [Required(ErrorMessage = "Project Number is required")]
        [StringLength(50, ErrorMessage = "Project Number cannot exceed 50 characters")]
        [Display(Name = "Project Number")]
        public string ProNumb { get; set; } = null!;

        [Required(ErrorMessage = "Project City is required")]
        [StringLength(50, ErrorMessage = "Project City cannot exceed 50 characters")]
        [Display(Name = "Project City")]
        public string ProCity { get; set; } = null!;

        [Required(ErrorMessage = "Project State is required")]
        [StringLength(2, ErrorMessage = "Project State cannot exceed 2 characters")]
        [Display(Name = "Project State")]
        public string ProState { get; set; } = null!;

        [Display(Name = "Employee")]
        [Required(ErrorMessage = "Employee is required")]
        public int EmployeeId { get; set; }

        [Display(Name = "Project Manager")]
        [Required(ErrorMessage = "Project Manager is required")]
        public int ProjectManagerId { get; set; }
        public string? ExelSheet { get; set; }
    }
    #endregion

    #region ProjectManagers
    public class ProjectManagerMetadata
    {
        public int ProjectManagerId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Email is required")]
        [StringLength(500, ErrorMessage = "Email cannot exceed 500 characters")]
        [Display(Name = "Email")]
        public string Email { get; set; } = null!;
    }
    #endregion

    #region Employees
    public class EmployeeMetadata
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters")]
        [Display(Name = "Last Name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;
    }
    #endregion
}
