using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.Appointment.Response
{
    public class GetAppointmentResponseDto
    {
        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public GetGenderDto Gender { get; set; }

        public GetAddressInformationResponseDto Address { get; set; }

        public GetScheduleInformationResponseDto Schedule { get; set; }

        public GetCommentResponseDto Comment { get; set; }
    }

    public sealed class GetAddressInformationResponseDto
    {
        public string POBox { get; set; }

        public string Area { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }

    public sealed class GetScheduleInformationResponseDto
    {
        public string ScheduledDate { get; set; }
    }

    public sealed class GetCommentResponseDto
    {
        public string Comment { get; set; }
    }
    public sealed class GetGenderDto
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
