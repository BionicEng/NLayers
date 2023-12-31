using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.Repositories
{
    public interface ICertificateRepository : IGenericRepository<CertificateEntity>
    {
        Task <List<CertificateEntity>> GetAllCertificates();
        Task<CertificateEntity> GetByIdCertificate(int Id);
        Task<List<CertificateEntity>> GetAllCertificatesWithUsers();
        Task<CertificateEntity> GetByIdCertificateWithUser(int Id);
    }
}
