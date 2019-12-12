using System;
using System.Collections.Generic;
using System.Text;

namespace CIS.ServiceContracts.ServiceObjects
{
    public sealed class ActivityTypeServiceObject
    {
        public int Id { get; set; }

        public int ActivityNumber { get; set; }

        public bool IsActive { get; set; }
    }
}
