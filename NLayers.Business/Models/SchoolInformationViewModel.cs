using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NLayers.Business.Models
{
    public class SchoolInformationViewModel
    {
        public int Id { get; set; }
        public string? SchoolName { get; set; } = string.Empty;
        public string? SchoolDescription { get; set; } = string.Empty;
        public string? Location { get; set; } = string.Empty;
        public int? UserId { get; set; }
        public UserViewModel? User { get; set; }
        public ICollection<SchoolDepartmentViewModel> StudentDepartments { get; set; }
    }
}
