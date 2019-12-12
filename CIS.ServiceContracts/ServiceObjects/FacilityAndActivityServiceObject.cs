using System;
using System.Collections.Generic;
using System.Text;

namespace CIS.ServiceContracts.ServiceObjects
{
    public sealed class FacilityAndActivityServiceObject
    {
        public int Id { get; set; }

        public int FacilityId { get; set; }

        public int ActivityId { get; set; }

        public bool IsActive { get; set; }

        public FacilityServiceObject Facility { get; set; }

        public ActivityTypeServiceObject Activity { get; set; }
    }
}
