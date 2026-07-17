using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    public class OrderItems
    {
        public int ID, OrderId, ProID, Quantity;
        public double Price, Amount;
        public string ItemName, CategoryName;
    }

}
