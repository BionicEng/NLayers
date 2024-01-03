using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.DTOs
{
    public class UserWithCertificateDTO : UserDTO
    {
        public ICollection<CertificateDTO> Certificates { get; set; }      
       
    }
}
