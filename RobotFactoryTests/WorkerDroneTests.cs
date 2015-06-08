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
    internal class WorkerDroneTests
    {

        [Test]
        public void WorkerDroneIdentifiesRobotPart()
        {
            RobotPart robotPart = new MockedAssembly();
            var workerDrone = new MockedWorkerDrone();

            var transportMechanism = workerDrone.IdentifyRobotPart(robotPart);
            Assert.IsInstanceOf<AssemblyRoomTransportMechanism>(transportMechanism);

            robotPart = new MockedWeapon();

            transportMechanism = workerDrone.IdentifyRobotPart(robotPart);
            Assert.IsInstanceOf<ArmouryTransportMechanism>(transportMechanism);
        }
    }
}
