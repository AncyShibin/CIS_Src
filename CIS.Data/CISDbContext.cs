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

        public DbSet<DepartmentEntity> Departments { get; set; }

        public DbSet<GenderEntity> Genders { get; set; }

        public DbSet<UserEntity> Users { get; set; }

        public DbSet<AppointmentEntity> Appointments { get; set; }

        public DbSet<AppointmentStatusEntity> AppointmentStatus { get; set; }

        public DbSet<CompanyEntity> Companies { get; set; }

        public DbSet<FacilityEntity> Facilities { get; set; }

        public DbSet<VisitTypeEntity> VisitTypes { get; set; }
    }
}