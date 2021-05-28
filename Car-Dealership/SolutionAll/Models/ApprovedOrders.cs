using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ApprovedOrders 
    {
        public List<PendingOrder> PendingOrders { get; set; }
        public ApprovedOrders(List<PendingOrder> pendingOrders) 
        {
            PendingOrders = pendingOrders;
        }
    }
}
