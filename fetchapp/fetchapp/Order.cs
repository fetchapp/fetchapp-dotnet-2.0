using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchApp
{
    public class Order
    {
        public int OrderID { get; set; }
        public int VendorID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String EmailAddress { get; set; }
        public float Total { get; set; }
        public Currency Currency { get; set; }
        public OrderStatus Status { get; set; }
        public int ProductCount { get; set; }
        public int DownloadCount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int DownloadLimit { get; set; }
        public String Custom1 { get; set; }
        public String Custom2 { get; set; }
        public String Custom3 { get; set; }
        public DateTime CreationDate { get; set; }

        
        public List<OrderItem> getItems()
        {
            List<OrderItem> orders = new List<OrderItem>();

            return orders;
        }

        public Boolean expire()
        {
            Boolean success = false;

            return success;
        }

        public Boolean sendDownloadEmail(Boolean resetExpiration = false, DateTime? expirationDate = null, int downloadLimit = -1)
        {
            Boolean success = false;

            return success;
        }

        public OrderStatistic getStatistics()
        {
            OrderStatistic stats = new OrderStatistic();

            return stats;
        }

        public List<OrderDownload> getDownloads()
        {
            List<OrderDownload> downloads = new List<OrderDownload>();

            return downloads;
        }
    }
}
