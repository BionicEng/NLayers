using System;
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
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserRoleID { get; set; }
        public string UserRoleName { get; set; } = string.Empty;
        public string UserRoleDescription { get; set;} = string.Empty;



        [ForeignKey(nameof(UserEntity))]
        public int UserID { get; set; }
        public virtual UserEntity UserEntity { get; set; }



        [ForeignKey(nameof(CompanyInfoEntity))]
        public int CompanyID { get; set; }
        public virtual CompanyInfoEntity CompanyInfoEntity { get; set; }

    }
}
