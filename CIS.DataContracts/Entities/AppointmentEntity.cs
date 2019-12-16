using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIS.DataContracts.Entities
{
    [Table("appointment")]
    public sealed class AppointmentEntity :BaseEntity
    {
        [Key] [Column("appointment_id")] public int Id { get; set; }

        [Column("name")] public string Name { get; set; }

        [Column("date_of_birth")] public DateTime DateOfBirth { get; set; }

        [Column("gender_id")] public int GenderId { get; set; }

        [Column("phone_number")] public string PhoneNumber { get; set; }

        [Column("mobile_number")] public string MobileNumber { get; set; }

        [Column("email")] public string Email { get; set; }

        [Column("po_box")] public string POBox { get; set; }

        [Column("area")] public string Area { get; set; }

        [Column("city")] public string City { get; set; }

        [Column("country")] public string Country { get; set; }

        [Required] [Column("scheduled_date")] public DateTime ScheduledDate { get; set; }

        [Column("comment")] public string Comment { get; set; }

        public GenderEntity Gender { get; set; }
    }
}
