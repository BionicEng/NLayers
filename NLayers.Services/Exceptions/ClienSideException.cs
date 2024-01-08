using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Services.Exceptions
{
    public class ClienSideException : Exception
    {
        public ClienSideException(string message) : base (message) { }

    }
}
