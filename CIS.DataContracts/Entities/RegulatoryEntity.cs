using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIS.DataContracts.Entities
{
    [Table("regulatory")]
    public sealed class RegulatoryEntity : BaseEntity
    {
        [Key] [Column("regulatory_id")] public int Id { get; set; }

        [Column("regulatory_name")] public string RegulatoryName { get; set; }
    }
}
