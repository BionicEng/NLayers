using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    public class UserEntity : IAuditEntity 
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Roles { get; set; } = string.Empty;
        public virtual ICollection<SpeakingLanguageEntity> Languages { get; set; }
        public virtual ICollection<KnownProgramEntity> KnownPrograms { get; set; }
        public virtual ICollection<UserSchoolDepartmentEntity> UserDepartments { get; set; }
        public virtual ICollection<CertificateEntity> Certificates { get; set; }
        public virtual UserAdressEntity UserAdress { get; set; }
        public virtual UserInformationEntity UserInfo { get; set; }
        public DateTime? CreatedAt { get ; set; }
        public DateTime? DeleteAt { get; set; }
        public DateTime? UpdateAt { get; set; }


        public UserEntity() => CreatedAt = DateTime.Now;
    }
}
