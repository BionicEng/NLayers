using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Services.Abstract
{
    public interface IKnownProgramService : IService<KnownProgramEntity>
    {
        Task<List<KnownProgramEntity>> GetAllKnownPrograms();
        Task<KnownProgramEntity> GetByIdKnownProgram(int Id);
        Task<List<KnownProgramEntity>> GetAllKnownProgramsWithUsers();
        Task<KnownProgramEntity> GetByIdKnownProgramWithUser(int Id);
    }
}
