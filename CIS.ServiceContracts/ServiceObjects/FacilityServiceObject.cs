using System;
using System.Collections.Generic;
using System.Text;

namespace CIS.ServiceContracts.ServiceObjects
{
    public sealed class FacilityServiceObject
    {
        public int Id { get; set; }

        public string FacilityName { get; set; }

        public string FacilityCode { get; set; }

        public string FacilityType { get; set; }
    }
}
