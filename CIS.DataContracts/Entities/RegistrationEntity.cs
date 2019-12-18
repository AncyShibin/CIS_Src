using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIS.DataContracts.Entities
{
    [Table("registration")]
    public sealed class RegistrationEntity : BaseEntity
    {
        [Key] [Column("registration_id")] public int Id { get; set; }

        [Column("reg_type")] public string Type { get; set; }

        [Column("name")] public string Name { get; set; }

        [Column("date_of_birth")] public DataType DateOfBirth { get; set; }

        [Column("gender_id")] public int GenderId { get; set; }

        [Column("phone_number")] public string PhoneNumber { get; set; }

        [Column("mobile_number")] public string MobileNumber { get; set; }

        [Column("email")] public string Email { get; set; }

        [Column("reg_address")] public string Address { get; set; }

        [Column("po_box")] public string POBox { get; set; }

        [Column("area")] public string Area { get; set; }

        [Column("city")] public string City { get; set; }

        [Column("country")] public string Country { get; set; }

        [Column("organization")] public string Organization { get; set; }

        [Column("physician")] public string Physician { get; set; }

        [Column("member_no")] public string MemberNumber { get; set; }

        [Column("employee_no")] public string EmployeeNumber { get; set; }

        [Column("validity")] public string Validity { get; set; }

        [Column("network")] public string Network { get; set; }

        [Column("sub_network")] public string SubNetwork { get; set; }

        public GenderEntity Gender { get; set; }
    }
}
