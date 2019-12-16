using CIS.DataContracts.Entities;
using CIS.DataContracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.Data.Repositories
{
    public sealed class AppointmentRepository : IAppointmentRepository
    {
        private readonly CISDbContext _dbContext;

        public AppointmentRepository(CISDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AppointmentEntity> CreateAppointmentAsync(AppointmentEntity appointmentEntity, CancellationToken token)
        {
            await _dbContext.Appointments.AddAsync(appointmentEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.Appointments
                                .Include(x => x.Gender)
                                .SingleAsync(appointment => appointment.Id == appointmentEntity.Id, token);
        }

        public async Task<IEnumerable<AppointmentEntity>> GetAppointmentListAsync(CancellationToken token)
        {
            return await _dbContext.Appointments
                                   .Include(x => x.Gender)
                                   .Where(appointment => appointment.IsActive).ToListAsync(token);
        }

        public async Task<AppointmentEntity> GetAppointmentByIdAsync(int appointmentId, CancellationToken token)
        {
            return await _dbContext.Appointments
                                    .Include(x => x.Gender)
                                    .FirstOrDefaultAsync(appointment => appointment.Id == appointmentId && appointment.IsActive, token);
        }

        public async Task<AppointmentEntity> UpdateAppointmentByIdAsync(AppointmentEntity appointmentEntity, CancellationToken token)
        {
            _dbContext.Appointments.Update(appointmentEntity);
            await _dbContext.SaveChangesAsync(token);
            return appointmentEntity;
        }

        public async Task DeleteAppointmentByIdAsync(int appointmentId, CancellationToken token)
        {
            var appointmentEntity = await _dbContext.Appointments
                                    .Include(x => x.Gender).
                                    SingleAsync(appointment => appointment.Id == appointmentId, token);
            appointmentEntity.IsActive = false;
            await _dbContext.SaveChangesAsync(token);
        }
    }
}
