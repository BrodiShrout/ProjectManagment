using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagment.DATA.EF.Models/*.Metadata*/
{
    [ModelMetadataType(typeof(ProjectMetadata))]
    public partial class Project
    {
        [NotMapped]
        public IFormFile? Exel { get; set; }
    }

    [ModelMetadataType(typeof(ProjectManagerMetadata))]
    public partial class ProjectManager { }

    [ModelMetadataType(typeof(EmployeeMetadata))]
    public partial class Employee { }
}
