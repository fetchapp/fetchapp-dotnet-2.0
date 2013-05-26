using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchApp
{
    public struct OrderStatistic
    {
        public String OrderID { get; set; }
        public String VendorID { get; set; }
        public int DownloadCount { get; set; }
        public int ProductCount { get; set; }
        public float OrderTotal { get; set; }
        public Currency Currency { get; set; }
    }
}
