using Microsoft.EntityFrameworkCore;
using NLayers.Core.Entities;
using NLayers.Core.Repositories;
using NLayers.Repository.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Repository.Repositories
{
    public class CertificateRepository : GenericRepository<CertificateEntity>,ICertificateRepository
    {
        public CertificateRepository(AppDbContext context) : base(context) { }

        public async Task<List<CertificateEntity>> GetAllCertificates()
        {
           return await _context.CertificatesTable.ToListAsync();
        }

        public async Task<List<CertificateEntity>> GetAllCertificatesWithUsers()
        {
            return await _context.CertificatesTable.Include(x=> x.User).ToListAsync();
        }

        public async Task<CertificateEntity> GetByIdCertificate(int Id)
        {
            return await _context.CertificatesTable.SingleOrDefaultAsync(x=>x.Id == Id);
        }

        public async Task<CertificateEntity> GetByIdCertificateWithUser(int Id)
        {
            return await _context.CertificatesTable.Include(x => x.User).SingleOrDefaultAsync(x => x.Id == Id);
        }
    }
}
