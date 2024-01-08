
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Models
{
    public class UserWithCertificatesViewModel : UserViewModel
    {
        public ICollection<CertificateViewModel> Certificates { get; set; }
    }
}
