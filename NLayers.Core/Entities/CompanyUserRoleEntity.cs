using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    public class CompanyUserRoleEntity
    {
        public int Id { get; set; }
        public string? UserRoleName { get; set; } = string.Empty;
        public string? UserRoleDescription { get; set;} = string.Empty;
        public int? CompanyInfosId { get; set; }
        public ICollection<CompanyInfoEntity> CompanyInfos { get; set; }

    }
}
