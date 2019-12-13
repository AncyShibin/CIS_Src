using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIS.DataContracts.Entities
{
    [Table("activity_type")]
    public sealed class ActivityTypeEntity : BaseEntity
    {
        [Key] [Column("activity_type_id")] public int Id { get; set; }

        [Column("activity_type")] public string ActivityType { get; set; }

        [Column("activity_number")] public int ActivityNumber { get; set; }
    }
}
