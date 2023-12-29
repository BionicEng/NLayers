using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    public class CertificateEntity : IFileEntity,IAuditEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CertificateID { get; set; }
        public string CertificateName { get; set; } = string.Empty;
        public string CertificateDescription { get; set; } = string.Empty;
        [ForeignKey(nameof(User))]
        public int UserID { get; set; }
        public virtual UserEntity User { get; set; }
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public DateTime? UpdateAt { get; set; }
    }
}
