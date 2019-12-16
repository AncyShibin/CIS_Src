using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.Appointment.Request
{
    public sealed class UpdateAppointmentRequestDto
    {
        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public int GenderId { get; set; }

        public string PhoneNumber { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }


        public UpdateAddressInformationRequestDto Address { get; set; }

        public UpdateScheduleInformationRequestDto Schedule { get; set; }

        public UpdateCommentRequestDto Comment { get; set; }
    }
    public sealed class UpdateAddressInformationRequestDto
    {
        public string POBox { get; set; }

        public string Area { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }

    public sealed class UpdateScheduleInformationRequestDto
    {
        public string ScheduledDate { get; set; }
    }

    public sealed class UpdateCommentRequestDto
    {
        public string Comment { get; set; }
    }
}
