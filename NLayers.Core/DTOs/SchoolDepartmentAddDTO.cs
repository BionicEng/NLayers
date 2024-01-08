using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.DTOs
{
    public class SchoolDepartmentAddDTO
    {
        public string? DepartmentName { get; set; } = string.Empty;
        public string? DepartmentDescription { get; set; } = string.Empty;
        public int? SchoolsId { get; set; }
    }
}
