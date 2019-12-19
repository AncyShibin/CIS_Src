using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.Appointment.Response
{
    public sealed class AddAppointmentResponseDto
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public AddGenderDto Gender { get; set; }

        public AddAddressInformationResponseDto Address { get; set; }

        public AddScheduleInformationResponseDto Schedule { get; set; }

        public AddCommentResponseDto Comment { get; set; }
    }
    public sealed class AddAddressInformationResponseDto
    {
        public string POBox { get; set; }

        public string Area { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }

    public sealed class AddScheduleInformationResponseDto
    {
        public string ScheduledDate { get; set; }
    }

    public sealed class AddCommentResponseDto
    {
        public string Comment { get; set; }
    }
    public sealed class AddGenderDto
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
