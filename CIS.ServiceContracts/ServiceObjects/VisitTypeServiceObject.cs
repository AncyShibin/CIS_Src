using System;
using System.Collections.Generic;
using System.Text;

namespace CIS.ServiceContracts.ServiceObjects
{
    public sealed class VisitTypeServiceObject
    {
        public int Id { get; set; }

        public string VisitType { get; set; }

        public string IsActive { get; set; }
    }
}
