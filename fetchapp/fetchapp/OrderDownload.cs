using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchAppAPI
{
    public struct OrderDownload
    {
        public String DownloadID { get; set; }
        public String FileName { get; set; }
        public String SKU { get; set; }
        public String OrderID { get; set; }
        public String IPAddress { get; set; }
        public DateTime DownloadedOn { get; set; }
        public int SizeInBytes { get; set; }
    }
}
