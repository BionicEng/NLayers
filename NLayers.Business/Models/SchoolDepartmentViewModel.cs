using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NLayers.Business.Models
{
    public class SchoolDepartmentViewModel
    {
        public int Id { get; set; }
        public string? DepartmentName { get; set; } = string.Empty;
        public string? DepartmentDescription { get; set; } = string.Empty;
        public int? SchoolsId { get; set; }
    }
}
