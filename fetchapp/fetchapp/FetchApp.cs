using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchAppAPI
{
    public class FetchApp
    {
        public String AuthenticationKey { get; set; }
        public String AuthenticationToken { get; set; }
        internal String EncodedCredentials { 
            get {
                return Convert.FromBase64String(this.AuthenticationKey + ":" + this.AuthenticationToken).ToString();
            } 
        }

        public FetchApp()
        {
            this.AuthenticationToken = null;
            this.AuthenticationKey = null;
        }

        public FetchApp(String authenticationKey, String authenticationToken)
        {
            this.AuthenticationKey = authenticationKey;
            this.AuthenticationToken = authenticationToken;
        }

        public AccountDetail getAccountDetails()
        {
            verifyReadiness();
            AccountDetail account = new AccountDetail();

            return account;
        }

        public List<Order> getOrders(OrderStatus status = OrderStatus.All, int itemsPerPage = -1, int pageNumber = -1)
        {
            List<Order> orders = new List<Order>();

            return orders;
        }

        private void verifyReadiness()
        {
            if (String.IsNullOrWhiteSpace(this.AuthenticationKey) || String.IsNullOrWhiteSpace(this.AuthenticationToken))
            {
                throw new AuthenticationException("You must configure an Authentication Key and an Authentication Token before you can connect to FetchApp.");
            }
        }


    }
}
