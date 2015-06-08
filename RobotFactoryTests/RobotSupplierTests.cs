using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RobotFactory;

namespace RobotFactoryTests
{
    [TestFixture]
    internal class RobotSupplierTests
    {
        [Test]
        public void RobotPartSupplierDeliversRobotParts()
        {
            var mechSupplier = new RobotPartSupplier
            {
                RobotParts = new List<RobotPart> {
                    new MockedRobotPart(),
                    new MockedRobotPart()
                }
            };

            var deliveryBay = new MockedDeliveryBay();
            mechSupplier.DeliverRobotParts(deliveryBay);

            Assert.AreEqual(2, deliveryBay.RobotParts.Count);
            Assert.AreEqual(0, mechSupplier.RobotParts.Count);
        }
    }
}
