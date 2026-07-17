using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    class Products
    {
        public int Id, CategoryId, Status;
        public string ItemName, Availability;
        public double Price;
        public byte[] ItemImage;
    }
}
