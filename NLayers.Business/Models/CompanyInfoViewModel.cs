using NLayers.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Models
{
    public class CompanyInfoViewModel
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; } = string.Empty;
        public string? CompanyAddress { get; set; } = string.Empty;
        public string? CompanyField { get; set; } = string.Empty;
        public string? CompanyDescription { get; set; } = string.Empty;
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public int UserId { get; set; }
        public ICollection<CompanyUserRoleViewModel> UserRoles { get; set; }
    }
}
