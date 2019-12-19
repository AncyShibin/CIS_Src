using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.Appointment.Response
{
    public class UpdateAppointmentResponseDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public UpdateGenderDto Gender { get; set; }

        public UpdateAddressInformationResponseDto Address { get; set; }

        public UpdateScheduleInformationResponseDto Schedule { get; set; }

        public UpdateCommentResponseDto Comment { get; set; }
    }
    public sealed class UpdateAddressInformationResponseDto
    {
        public string POBox { get; set; }

        public string Area { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }

    public sealed class UpdateScheduleInformationResponseDto
    {
        public string ScheduledDate { get; set; }
    }

    public sealed class UpdateCommentResponseDto
    {
        public string Comment { get; set; }
    }
    public sealed class UpdateGenderDto
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
