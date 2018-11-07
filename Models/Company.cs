using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIdentityDemo.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName{ get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyZip { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhone { get; set; }

    }
}
