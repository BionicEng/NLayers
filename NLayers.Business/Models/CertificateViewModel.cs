using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Models
{
    public class CertificateViewModel
    {
        public int Id { get; set; }
        public string? CertificateName { get; set; } = string.Empty;
        public string? CertificateDescription { get; set; } = string.Empty;
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? UserId { get; set; }
    }
}
