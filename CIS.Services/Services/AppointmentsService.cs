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
    public sealed class AppointmentsService : IAppointmentsService
    {
        private readonly IAppointmentRepository _appointmentRepository;
        private readonly IMapper _mapper;

        public AppointmentsService(
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

        public async Task<IEnumerable<AppointmentServiceObject>> SearchAppointmentAsync(string searchQuery, CancellationToken token)
        {
            var serviceResult = await _appointmentRepository.SearchAppointmentAsync(searchQuery, token);
            return _mapper.Map<IEnumerable<AppointmentServiceObject>>(serviceResult);
        }
    }
}
