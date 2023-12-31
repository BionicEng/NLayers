using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    public class SchoolDepartmentEntity
    {
        public int Id { get; set; }
        public string? DepartmentName { get; set; } = string.Empty;
        public string? DepartmentDescription {get; set; } = string.Empty;    
        public int? SchoolsId { get; set; }
        public ICollection<SchoolInformationEntity> Schools { get; set; }
    }
}
