using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    public class Orders
    {
        public int Id,OrderNo, CustomerId;
        public DateTime OrderDate;
        public string TableName, WaiterName, OrderType, OrderTime,CustomerName, PaymentStatus;
        public double Total, Received, OrderChanged,Discount;
    }

    public static class Order
    {
        public static Orders CurrentOrder;
    }
 
}
