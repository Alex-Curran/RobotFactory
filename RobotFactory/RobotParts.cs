using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory
{
    public abstract class RobotPart
    {
       private readonly RobotPartCategory _robotPartCategory;

        public RobotPartCategory RobotPartCategory { get { return _robotPartCategory; } }

        protected RobotPart(RobotPartCategory robotPartCategory) {
            _robotPartCategory = robotPartCategory;
        }
    }
}
