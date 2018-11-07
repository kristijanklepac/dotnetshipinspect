using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIdentityDemo.Models
{
    public class RecognizedOrganization
    {
        public int RecognizedOrganizationId { get; set; }
        public string RecognizedOrganizationName { get; set; }
        public string RecognizedOrganizationInitials { get; set; }
        public string RoParisMou { get; set; }
        public string RoTokyoMou { get; set; }
        public string RoCarribeanMou { get; set; }
        public string RoMediterraneanMou { get; set; }
        public string RoVinaDelMarMou { get; set; }
        public string RoUsCoastGuardMou { get; set; }
        public string RoIndianOceanMou { get; set; }
        public string RoRiyadhMou { get; set; }

    }
}
