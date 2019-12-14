using System;
using System.Collections.Generic;
using System.Text;

namespace CIS.ServiceContracts.ServiceObjects
{
    public sealed class MedicalRecordServiceObject
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public int FacilityId { get; set; }

        public int EncounterId { get; set; }

        public int RegulatoryId { get; set; }

        public bool IsActive { get; set; }

        public CompanyServiceObject Company { get; set; }

        public FacilityServiceObject Facility { get; set; }

        public EncounterTypeServiceObject Encounter { get; set; }

        public RegulatoryServiceObject Regulatory { get; set; }
    }
}
