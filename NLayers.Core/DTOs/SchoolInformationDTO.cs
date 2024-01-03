using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.DTOs
{
    public class SchoolInformationDTO
    {
        public int Id { get; set; }
        public string? SchoolName { get; set; } = string.Empty;
        public string? SchoolDescription { get; set; } = string.Empty;
        public string? Location { get; set; } = string.Empty;
        public int? UserId { get; set; }
        public ICollection<SchoolDepartmentDTO> StudentDepartments { get; set; }
    }
}
