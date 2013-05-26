using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchApp
{
    public class OrderItem
    {
        public int ItemID { get; set; }
        public String SKU { get; set; }
        public String OrderID { get; set; }
        public String ProductName { get; set; }
        public float Price { get; set; }
        public int DownloadCount { get; set; }
        public String Custom1 { get; set; }
        public String Custom2 { get; set; }
        public String Custom3 { get; set; }
        public DateTime CreationDate { get; set; }

        public List<FileDetail> getFiles()
        {
            List<FileDetail> files = new List<FileDetail>();

            return files;
        }
    }
}
