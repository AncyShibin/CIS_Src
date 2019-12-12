using System;
using System.Collections.Generic;
using System.Text;

namespace CIS.ServiceContracts.ServiceObjects
{
    public sealed class EncounterTypeServiceObject
    {
        public int Id { get; set; }

        public string EncounterType { get; set; }

        public string IsActive { get; set; }
    }
}
