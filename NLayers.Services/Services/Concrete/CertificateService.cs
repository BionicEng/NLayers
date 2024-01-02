using NLayers.Core.Entities;
using NLayers.Core.Repositories;
using NLayers.Core.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Services.Services.Concrete
{
    public class CertificateService : Service<CertificateEntity>, ICertificateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICertificateRepository _certificateRepository;
        public CertificateService(IGenericRepository<CertificateEntity> repository, ICertificateRepository certificateRepository, IUnitOfWork unitOfWork) : base(unitOfWork, repository)
        {
            _certificateRepository = certificateRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<CertificateEntity>> GetAllCertificates()
        {
            return await _certificateRepository.GetAllCertificates();
        }

        public async Task<List<CertificateEntity>> GetAllCertificatesWithUsers()
        {
            return await _certificateRepository.GetAllCertificatesWithUsers();
        }

        public async Task<CertificateEntity> GetByIdCertificate(int Id)
        {
            return await _certificateRepository.GetByIdCertificate(Id);
        }

        public async  Task<CertificateEntity> GetByIdCertificateWithUser(int Id)
        {
            return await _certificateRepository.GetByIdCertificateWithUser(Id);
        }
    }
}
