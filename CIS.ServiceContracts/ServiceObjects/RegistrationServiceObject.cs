using System;
using System.Collections.Generic;
using System.Text;

namespace CIS.ServiceContracts.ServiceObjects
{
    public sealed class RegistrationServiceObject
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int GenderId { get; set; }

        public string PhoneNumber { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string POBox { get; set; }

        public string Area { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Organization { get; set; }

        public string Physician { get; set; }

        public string MemberNumber { get; set; }

        public string EmployeeNumber { get; set; }

        public string Validity { get; set; }

        public string Network { get; set; }

        public string SubNetwork { get; set; }

        public GenderServiceObject Gender { get; set; }
    }
}
