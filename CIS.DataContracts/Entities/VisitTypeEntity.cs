using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIS.DataContracts.Entities
{
    [Table("visit_type")]
    public sealed class VisitTypeEntity : BaseEntity
    {
        [Key] [Column("visit_type_id")] public int Id { get; set; }

        [Column("visit_type")] public string VisitType { get; set; }
    }
}
