using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchAppAPI
{
    public class AccountDetail
    {
        public int AccountID { get; set; }
        public String AccountName { get; set; }
        public String EmailAddress { get; set; }
        public String URL { get; set; }
        public String BillingEmail { get; set; }
        public int OrderExpirationInHours { get; set; }
        public int ItemDownloadLimit { get; set; }
        public Currency Currency { get; set; }
        public DateTime CreationDate { get; set; }
        public String APIKey { get; set; }
        public String APIToken { get; set; }


    }
}
