using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.MedicalRecord.Request
{
    public class UpdateMedicalRecordRequestDto
    {
        public int CompanyId { get; set; }

        public int FacilityId { get; set; }

        public int EncounterId { get; set; }

        public int RegulatoryId { get; set; }
    }
}
