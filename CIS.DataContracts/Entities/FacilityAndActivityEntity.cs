using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIS.DataContracts.Entities
{
    [Table("facility_and_activity_mapping")]
    public sealed class FacilityAndActivityEntity : BaseEntity
    {
        [Key] [Column("facility_and_activity_mapping_id")] public int Id { get; set; }

        [Column("facility_id")] public int FacilityId { get; set; }

        [Column("activity_id")] public int ActivityId { get; set; }

        public FacilityEntity Facility { get; set; }

        public ActivityTypeEntity Activity { get; set; }
    }
}
