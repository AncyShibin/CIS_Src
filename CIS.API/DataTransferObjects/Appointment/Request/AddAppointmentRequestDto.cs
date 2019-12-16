using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.Appointment.Request
{
    public sealed class AddAppointmentRequestDto
    {
        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public int GenderId { get; set; }

        public string PhoneNumber { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }


        public CreateAddressInformationRequestDto Address { get; set; }

        public CreateScheduleInformationRequestDto Schedule { get; set; }

        public CreateCommentRequestDto Comment { get; set; }
    }

    public sealed class CreateAddressInformationRequestDto
    {
        public string POBox { get; set; }

        public string Area { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }

    public sealed class CreateScheduleInformationRequestDto
    {
        public string ScheduledDate { get; set; }
    }

    public sealed class CreateCommentRequestDto
    {
        public string Comment { get; set; }
    }
}
