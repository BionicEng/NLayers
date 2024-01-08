using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.DTOs
{
    public class SchoolInformationAddDTO
    {
        public string? SchoolName { get; set; } = string.Empty;
        public string? SchoolDescription { get; set; } = string.Empty;
        public string? Location { get; set; } = string.Empty;
        public int? UserId { get; set; }
    }
}

