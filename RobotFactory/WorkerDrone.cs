using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory
{
    public abstract class WorkerDrone
    {
        public TransportMechanism TransportMechanism { get; private set; }

        public void IdentifyRobotPart(RobotPart robotPart)
        {
            switch (robotPart.RobotPartCategory)
            {
                case RobotPartCategory.Assembly:
                    TransportMechanism = new AssemblyRoomTransportMechanism();
                    break;
                case RobotPartCategory.Weapon:
                    TransportMechanism = new ArmouryTransportMechanism();
                    break;
            }
        }
    }
}
