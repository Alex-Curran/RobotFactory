﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory
{
    public class DeliveryBay : FactoryRoom
    {
        public List<RobotPart> RobotParts { get; set; }
    }
}
