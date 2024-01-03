using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.DTOs
{
    public class UserInformationDTO
    {
        public int Id { get; set; }
        public string? UserDescription { get; set; } = string.Empty;
        public DateTime? BirtDay { get; set; }
        public string? Gender { get; set; } = string.Empty;
        public bool? MSwasDone { get; set; }
        public string? Hobies { get; set; } = string.Empty;
        public string? FileName { get; set; }
        public string? FilePath { get; set; }

    }
}
