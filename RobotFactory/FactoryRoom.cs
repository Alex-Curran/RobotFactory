using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory
{
    public abstract class FactoryRoom
    {
        private readonly List<RobotPart> _robotParts;

        protected FactoryRoom()
        {
            _robotParts = new List<RobotPart>();
        }
    }
}
