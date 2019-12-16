using AutoMapper;
using CIS.DataContracts.Entities;
using CIS.DataContracts.Repositories;
using CIS.ServiceContracts.ServiceObjects;
using CIS.ServiceContracts.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.Services.Services
{
    public sealed class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper;

        public AppointmentService(
            IAppointmentRepository appointmentRepository,
            IMapper mapper)
        {
            _appointmentRepository = appointmentRepository;
            _mapper = mapper;
        }

        public async Task<AppointmentServiceObject> CreateAppointmentAsync(AppointmentServiceObject appointmentServiceObject, CancellationToken token)
        {
            var appointmentEntity = _mapper.Map<AppointmentEntity>(appointmentServiceObject);
            var createdEntity = await _appointmentRepository.CreateAppointmentAsync(appointmentEntity, token);
            return _mapper.Map<AppointmentServiceObject>(createdEntity);
        }

        public async Task<IEnumerable<AppointmentServiceObject>> GetAppointmentListAsync(CancellationToken token)
        {
            var serviceResult = await _appointmentRepository.GetAppointmentListAsync(token);
            return _mapper.Map<IEnumerable<AppointmentServiceObject>>(serviceResult);
        }

        public async Task<AppointmentServiceObject> GetAppointmentByIdAsync(int appointmentId, CancellationToken token)
        {
            var serviceResult = await _appointmentRepository.GetAppointmentByIdAsync(appointmentId, token);
            return _mapper.Map<AppointmentServiceObject>(serviceResult);
        }

        public async Task<AppointmentServiceObject> UpdateAppointmentByIdAsync(AppointmentServiceObject appointmentServiceObject, CancellationToken token)
        {
            var appointmentEntity = _mapper.Map<AppointmentEntity>(appointmentServiceObject);
            var updatedEntity = await _appointmentRepository.UpdateAppointmentByIdAsync(appointmentEntity, token);
            return _mapper.Map<AppointmentServiceObject>(updatedEntity);
        }

        public async Task DeleteAppointmentByIdAsync(int appointmentId, CancellationToken token)
        {
            await _appointmentRepository.DeleteAppointmentByIdAsync(appointmentId, token);
        }
    }
}
