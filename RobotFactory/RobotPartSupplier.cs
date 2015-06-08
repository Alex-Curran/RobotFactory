using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory
{
    public class RobotPartSupplier : Supplier
    {
        public void DeliverRobotParts(DeliveryBay deliveryBay)
        {
            deliveryBay.RobotParts = new List<RobotPart>(RobotParts);
            RobotParts.Clear();
        }
    }
}
