using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIS.DataContracts.Entities
{
    [Table("facility")]
    public sealed class FacilityEntity : BaseEntity
    {
        [Key] [Column("faciltiy_id")] public int Id { get; set; }

        [Column("facility_name")] public string FacilityName { get; set; }

        [Column("facility_code")] public string FacilityCode { get; set; }

        [Column("facility_type")] public string FacilityType { get; set; }
    }
}
