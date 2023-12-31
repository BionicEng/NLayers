using NLayers.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Services.Abstract
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
        void Commit();
    }
}
#region Notlar
//UnitofWork Design Pattern Nedir?

//Bu pattern, iş katmanında yapılan her değişikliğin anlık olarak database e yansıması yerine, işlemlerin toplu halde tek bir kanaldan gerçekleşmesini sağlar.


#endregion