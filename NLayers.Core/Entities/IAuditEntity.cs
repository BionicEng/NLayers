using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Entities
{
    internal interface IAuditEntity
    {
        DateTime? CreatedAt { get; set; }
        DateTime? DeleteAt { get; set; }
        DateTime? UpdateAt { get; set; }
    }
}
