using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIdentityDemo.Models
{
    public class Inspection
    {
        public int InspectionId { get; set; }
        public string ShipName { get; set; }
        public string PortOfInspection { get; set; }
        public DateTime DateOfInspection { get; set; }
        public string MouName { get; set; }
        public int IsmDefiencies { get; set; }
        public int NonIsmDefiencies { get; set; }
        public int TotalDefiencies { get; set; }
        public bool VesselDetained { get; set; }
        public bool RefusalOfAccess { get; set; }
        public string FollowUpRectified { get; set; }
    }
}
