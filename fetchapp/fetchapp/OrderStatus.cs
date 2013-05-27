using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchAppAPI
{
    public enum OrderStatus
    {
        /// <summary>
        /// Used for Open Orders
        /// </summary>
        Open,
        /// <summary>
        /// Used for Expired Orders
        /// </summary>
        Expired,
        /// <summary>
        /// Used for All Orders
        /// </summary>
        All
    }
}
