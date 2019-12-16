using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.ServiceContracts.Services
{
    public  interface IAppointmentService
    {
        Task<AppointmentServiceObject> CreateAppointmentAsync(AppointmentServiceObject appointmentServiceObject, CancellationToken token);

        Task<IEnumerable<AppointmentServiceObject>> GetAppointmentListAsync(CancellationToken token);

        Task<AppointmentServiceObject> GetAppointmentByIdAsync(int appointmentId, CancellationToken token);

        Task<AppointmentServiceObject> UpdateAppointmentByIdAsync(AppointmentServiceObject appointmentServiceObject, CancellationToken token);

        Task DeleteAppointmentByIdAsync(int appointmentId, CancellationToken token);
    }
}
