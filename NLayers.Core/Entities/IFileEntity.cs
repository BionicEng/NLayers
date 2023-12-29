using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    public interface IFileEntity
    {
        string? FileName { get; set; }
        string? FilePath { get; set; }
    }
}
