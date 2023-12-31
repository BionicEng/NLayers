using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    public class CompanyInfoEntity : IFileEntity
    {
        public int Id { get; set; }
        public string? CompanyName { get; set; } = string.Empty;
        public string? CompanyAddress { get; set; } = string.Empty;
        public string? CompanyField { get; set; } = string.Empty;
        public string? CompanyDescription { get; set; } = string.Empty;       
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public int? UserId { get; set; }

        public ICollection<CompanyUserRoleEntity> UserRoles { get; set; }
        public ICollection<UserEntity>User { get; set; }

    }
}
