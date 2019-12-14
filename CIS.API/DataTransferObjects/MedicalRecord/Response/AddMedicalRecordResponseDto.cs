using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.MedicalRecord.Response
{
    public class AddMedicalRecordResponseDto
    {
        public string Id { get; set; }

        public int CompanyId { get; set; }

        public int FacilityId { get; set; }

        public int EncounterId { get; set; }

        public int RegulatoryId { get; set; }

        public bool Status { get; set; }

        public CompanyResponseDto Company { get; set; }

        public FacilitiesResponseDto Facility { get; set; }

        public EncounterResponseDto Encounter { get; set; }

        public RegulatoryResponseDto Regulatory { get; set; }
    }
}
