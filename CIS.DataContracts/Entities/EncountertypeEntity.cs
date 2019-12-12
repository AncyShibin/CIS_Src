using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIS.DataContracts.Entities
{
    [Table("encounter_type")]
    public sealed class EncounterTypeEntity : BaseEntity
    {
        [Key] [Column("encounter_type_id")] public int Id { get; set; }

        [Column("encounter_type")] public string EncounterType { get; set; }

    }
}
