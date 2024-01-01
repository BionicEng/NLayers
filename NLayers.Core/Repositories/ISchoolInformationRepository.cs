using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Repositories
{
    public interface ISchoolInformationRepository : IGenericRepository<SchoolInformationEntity>
    {
        public Task<List<SchoolInformationEntity>> GetAllSchoolInformations();
        public Task<List<SchoolInformationEntity>> GetAllSchoolInformationsWithUser();
        public Task<List<SchoolInformationEntity>> GetAllSchoolInformationsWithDepartments();

        public Task<SchoolInformationEntity> GetSchoolInformationById(int id);
        public Task<SchoolInformationEntity> GetSchoolInformationWithUserById(int id);
        public Task<SchoolInformationEntity> GetSchoolInformationWithDepartmentsById(int id);
    }
}
