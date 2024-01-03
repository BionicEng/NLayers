using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    public class SchoolInformationEntity
    {
        public int Id { get; set; }
        public string? SchoolName { get; set; } = string.Empty;
        public string? SchoolDescription { get; set;} = string.Empty;
        public string? Location { get; set; } = string.Empty;
        public int? UserId { get; set; }
        public ICollection<SchoolDepartmentEntity> StudentDepartments { get; set; }
        
        public UserEntity? User { get; set; }
    }
}
