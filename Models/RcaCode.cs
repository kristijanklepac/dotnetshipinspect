using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIdentityDemo.Models
{
    public class RcaCode
    {
        public int RcaCodeId { get; set; }
        public int DefaultCodeId { get; set; }
        public string CodeDescription { get; set; }
        public string RelatedRootCodeId { get; set; }
    }
}
