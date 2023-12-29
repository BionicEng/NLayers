using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    public class StudentDepartmentEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Department { get; set; }
        public string DepartmentName { get; set; } = string.Empty;

        public virtual ICollection<SchoolInformationEntity> Schools { get; set; }
    }
}
