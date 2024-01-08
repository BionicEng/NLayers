using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Models
{
    public class CompanyUserRoleViewModel
    {
        public int Id { get; set; }
        public string? UserRoleName { get; set; } = string.Empty;
        public string? UserRoleDescription { get; set; } = string.Empty;
        public int? CompanyInfoId { get; set; }
    }
}
