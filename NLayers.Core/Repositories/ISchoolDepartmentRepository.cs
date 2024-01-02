using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Repositories
{
    public interface ISchoolDepartmentRepository : IGenericRepository<SchoolDepartmentEntity>    
    {
        public Task<List<SchoolDepartmentEntity>> GetAllSchoolDepartmentAsync();
        public Task<SchoolDepartmentEntity> GetByIdSchoolDepartmentAsync(int Id);

        public Task<List<SchoolDepartmentEntity>> GetAllSchoolDepartmentWithSchoolInfoAsync();
        public Task<SchoolDepartmentEntity> GetByIdSchoolDepartmentWithSchoolInfoAsync(int Id);

        public Task<List<SchoolDepartmentEntity>> GetAllSchoolDepartmentWithSchoolInfoWithUserAsync();
        public Task<SchoolDepartmentEntity> GetByIdSchoolDepartmentWithSchoolInfoWithUserAsync(int Id);
    }
}
