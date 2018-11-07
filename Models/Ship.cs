using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIdentityDemo.Models
{
    public class Ship
    {
        public int ShipId { get; set; }
        public string ShipName { get; set; }
        public string CompanyName { get; set; }
        public int ImoNumber { get; set; }
        public string ClassOrganization { get; set; }
        public string RecognizedOrganization { get; set; }
        public string CountryFlag { get; set; }
        public string OfficialNr { get; set; }
        public string Year { get; set; }
        public string GT { get; set; }
        public string TypeOfShip { get; set; }

    }
}
