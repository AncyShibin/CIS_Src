using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIS.DataContracts.Entities
{
    [Table("medical_record")]
    public class MedicalRecordEntity : BaseEntity
    {
        [Key] [Column("medical_record_id")] public int Id { get; set; }

        [Column("company_id")] public int CompanyId { get; set; }

        [Column("facility_id")] public int FacilityId { get; set; }

        [Column("encounter_type_id")] public int EncounterId { get; set; }

        [Column("regulatory_id")] public int RegulatoryId { get; set; }

        public CompanyEntity Company { get; set; }

        public FacilityEntity Facility { get; set; }

        public EncounterTypeEntity Encounter { get; set; }

        public RegulatoryEntity Regulatory { get; set; }
    }
}
