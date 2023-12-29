using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    public class UserSchoolDepartmentEntity
    {
        [Key]
        public int UserDepartmentID { get; set; }



        [ForeignKey(nameof(User))]
        public int UserID { get; set; }
        public virtual UserEntity User { get; set; }



        [ForeignKey(nameof(School))]
        public int SchoolID { get; set; }
        public virtual SchoolInformationEntity School { get; set; }



        [ForeignKey(nameof(Department))]
        public int DepartmentID { get; set; }
        public virtual StudentDepartmentEntity Department { get; set; }
    }
}
