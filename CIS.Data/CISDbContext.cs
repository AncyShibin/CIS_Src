using System.ComponentModel.DataAnnotations.Schema;
using CIS.DataContracts.Entities;
using Microsoft.EntityFrameworkCore;

namespace CIS.Data
{
    public sealed class CISDbContext : DbContext
    {
        public CISDbContext(DbContextOptions<CISDbContext> options) : base(options)
        {

        }

        public DbSet<CompanyEntity> Companies { get; set; }

        public DbSet<FacilityEntity> Facilities { get; set; }

        public DbSet<VisitTypeEntity> VisitTypes { get; set; }

        public DbSet<RegulatoryEntity> Regulatories { get; set; }
        
    }
}