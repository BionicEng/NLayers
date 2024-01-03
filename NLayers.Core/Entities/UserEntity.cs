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
        public ICollection<CertificateEntity> Certificates { get; set; }
        public ICollection<SpeakingLanguageEntity> Languages { get; set; }
        public ICollection<KnownProgramEntity> KnownPrograms { get; set; }
        public ICollection<CompanyInfoEntity> CompanyInfos { get; set; }
        public UserInformationEntity? UserInfo { get; set; }
        public UserAdressEntity? UserAdress { get; set; }
        public ICollection<SchoolInformationEntity>SchoolInfos { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Roles { get; set; } = string.Empty;
        public DateTime? CreatedAt { get ; set; }
        public DateTime? DeleteAt { get; set; }
        public DateTime? UpdateAt { get; set; }


        public UserEntity() => CreatedAt = DateTime.Now;
    }
}
