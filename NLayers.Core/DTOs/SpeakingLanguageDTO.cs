using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.DTOs
{
    public class SpeakingLanguageDTO
    {
        public int Id { get; set; }
        public string? LanguageName { get; set; }
        public string? LanguageDescription { get; set; }

        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public int? UserId { get; set; }
    }
}
