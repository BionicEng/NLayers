using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.DTOs
{
    public class CompanyUserRoleAddDTO
    {
        public string? UserRoleName { get; set; } = string.Empty;
        public string? UserRoleDescription { get; set; } = string.Empty;
        public int? CompanyInfoId { get; set; }
    }
}
