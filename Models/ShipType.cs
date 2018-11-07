using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIdentityDemo.Models
{
    public class ShipType
    {
        public int ShipTypeId { get; set; }
        public string ShipTypeName { get; set; }
        public int PointsOfHrs { get; set; }
        public bool CanBeLrs { get; set; }
    }
}
