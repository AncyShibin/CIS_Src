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

        Task<IEnumerable<AppointmentEntity>> SearchAppointmentAsync(string searchQuery, CancellationToken token);
    }
}
