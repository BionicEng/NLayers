using NLayers.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Models
{
    public class UserWithCompanyInfoViewModel : UserViewModel
    {
        public ICollection<CompanyInfoViewModel> CompanyInfos { get; set; }
    }
}
