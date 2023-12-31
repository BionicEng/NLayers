﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    public class KnownProgramEntity :IFileEntity,IAuditEntity
    {
        public int Id { get; set; }
        public string? ProgramName { get; set; } = string.Empty;
        public string? ProgramDescription { get; set; } = string.Empty;
        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }
        public UserEntity? User { get; set; }
    }
}
