using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIdentityDemo.Models
{
    public class WGBList
    {
        public int WgbListId { get; set; }

        // country Flag
        public string WgbFlag { get; set; }

        // white or grey or black
        public string WorGorB { get; set; }

        // Black Medium or Black Medium To High or Black High or Black Very High Risk
        public string BmBmthBhBvhr { get; set; }


    }
}
