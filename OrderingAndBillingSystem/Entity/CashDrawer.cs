using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingAndBillingSystem.Entity
{
    class CashDrawer
    {
        public int Id;
        public DateTime Date;
        public string TimeStart, TimeClose, Status;
        public double StartingCash;
    }
}
