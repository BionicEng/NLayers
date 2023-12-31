using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    public class SpeakingLanguageEntity : IFileEntity
    {
        public int Id { get; set; }
        public string? LanguageName { get; set; }
        public string? LanguageDescription { get; set;}

        public string? FileName { get; set; }
        public string? FilePath { get; set; }
        public int? UserId { get; set; }
        public ICollection<UserEntity> User { get; set; }
    }
}
