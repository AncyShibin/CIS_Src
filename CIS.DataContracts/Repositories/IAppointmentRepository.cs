using CIS.DataContracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.DataContracts.Repositories
{
    public interface IAppointmentRepository
    {
        Task<AppointmentEntity> CreateAppointmentAsync(AppointmentEntity appointmentEntity, CancellationToken token);

        Task<IEnumerable<AppointmentEntity>> GetAppointmentListAsync(CancellationToken token);

        Task<AppointmentEntity> GetAppointmentByIdAsync(int appointmentId, CancellationToken token);

        Task<AppointmentEntity> UpdateAppointmentByIdAsync(AppointmentEntity appointmentEntity, CancellationToken token);

        Task DeleteAppointmentByIdAsync(int appointmentId, CancellationToken token);
    }
}
